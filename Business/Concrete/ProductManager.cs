using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal  _productDal;
        //Give me a reference of IProduct dal   
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //Business Codes - If checks in here, if allowed then return products.
            //Business layer enables authorization, control etc.
            return _productDal.GetAll();
        }
    }
}
