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
            // @ means \ does not have a meaning just a path.
            optionsBuilder.UseSqlServer(@"Server=");
        }
    }
}
