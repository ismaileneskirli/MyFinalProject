﻿using DataAccess.Abstract;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products; // _ means global variable within the class, Product is a class in Entities
        public InMemoryProductDal()
        {   
            // Simulate data access.
            _products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1,ProductName="Glass",UnitPrice=15,UnitsInStock=15},
                new Product{ProductId=1, CategoryId=1,ProductName="Phone",UnitPrice=1000,UnitsInStock=3},
                new Product{ProductId=1, CategoryId=1,ProductName="Mac",UnitPrice=1500,UnitsInStock=5},
                new Product{ProductId=1, CategoryId=1,ProductName="Pen",UnitPrice=25,UnitsInStock=100}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //Language Integrated Query = LINQ
            Product productToDelete = null;
            //instead of iterate through list with loop use it. It means for each p in _product list
            //look if id equals product id in the parameter. Singleordefault means foreach.
            productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryID)
        {
            // Where function returns all the objects that meets the if condition.
            return _products.Where(p => p.CategoryId == categoryID).ToList();
        }

        public void Update(Product product)
        {
            //Find the product, now productToUpdate referencing the product in the list(memory db)
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }
    }
}
