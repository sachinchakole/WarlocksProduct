using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WarlocksProduct.Areas.Admin.Models;
using WarlocksProduct.Models;

namespace WarlocksProduct.DataContext
{
    public class WarlocksDbContext:DbContext
    {
        public WarlocksDbContext() : base("name=WarlocksDbConnection")
        {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
       
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<User> Users { get; set; }  
    }
   
}