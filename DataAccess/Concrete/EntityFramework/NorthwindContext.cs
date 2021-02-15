using Entitites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{

    // Context object : link db tables with  project classes(under entities->concrete)
    public class NorthwindContext:DbContext
    {
        // which database is related with my project ?
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // @ means \ does not have a meaning, it is  just a path. You dont need to write //.
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }
        // Which class represent which table.  

        public DbSet<Product> Products { get; set; } 

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
