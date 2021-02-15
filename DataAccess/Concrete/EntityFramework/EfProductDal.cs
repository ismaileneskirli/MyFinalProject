using DataAccess.Abstract;
using Entitites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

//ORM = object relational mapping .
//relate db tables with classes.
namespace DataAccess.Concrete.EntityFramework
{
    //NuGet : packages  
    public class EfProductDal : IProductDal
    {
        public void Add( Product entity)
           {  //Disposable pattern implementation of c#
              // When using block finished, delete NorthwindContext from memory.
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity = context.Entry(entity); // Get referance of entity in the db.
                addedEntity.State = EntityState.Added; // add the entity to table
                context.SaveChanges(); // save changes to the table.

            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity); // Get referance of entity in the db.
                deletedEntity.State = EntityState.Deleted; // delete the entity from table
                context.SaveChanges(); // save changes to the table.

            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                // Convert Product table to a list and return it
                // What it returns is Select * from Products
                // if filter == null then first line : if not second line.
                return filter == null 
                    ? context.Set<Product>().ToList()
                    : context.Set<Product>().Where(filter).ToList();
            }
        }

        public List<Product> GetAllByCategory(int categoryID)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity); // Get referance of entity in the db.
                updatedEntity.State = EntityState.Modified; // update the entity from table
                context.SaveChanges(); // save changes to the table.

            }
        }
    }
}
