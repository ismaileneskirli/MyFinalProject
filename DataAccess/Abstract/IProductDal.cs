using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal //Dal stands for Data access Layer.
    {
        List<Product> GetAll();

        void Add(Product product);

        void Update(Product product);

        void Delete(Product product);

        List<Product> GetAllByCategory(int categoryID); //Filtering categories
    }
}
