using Entitites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Generic, tell me type you want to work.
    // class : reference type
    //  Where means T can be a class implemented from IEntity.
    // new means it can be newable, meaning that IEntity interfaces can not implement this interface.
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        // You dont need to write different functions for different queries.
        List<T> GetAll(Expression<Func<T, bool>> filter= null); //filter null means filter is not mandatory. You may not give it.

        T Get(Expression<Func<T, bool>> filter); // filter is mandatory in here.

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        List<T> GetAllByCategory(int categoryID); //Filtering categories
    }
}
