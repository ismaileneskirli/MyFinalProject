using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{    //Dal stands for Data access Layer.
    // IProductDal is a IEntityRepository structured with Product class/table 
    public interface IProductDal:IEntityRepository<Product>
    {

    }
}
