using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using ShopVVK.Data.Models;

namespace ShopVVK.Data
{
    public class AppDBContent : DbContext
    {
        //public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        //{

        //}

        public DbSet<Car> Car {get; set;}
        //public DbSet<Category> Category { get; set; }
        //public DbSet<ShopCartItem> ShopCartItem { get; set; }
    }
}
