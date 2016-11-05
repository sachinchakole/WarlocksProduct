using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WarlocksProduct.Areas.Admin.Models;


namespace WarlocksProduct.DataContext
{
    public class AdminDbContext:DbContext
    {
        public AdminDbContext() : base("WarlocksDbConnection")
        {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
