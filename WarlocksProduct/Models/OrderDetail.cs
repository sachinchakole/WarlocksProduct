using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WarlocksProduct.Areas.Admin.Models;

namespace WarlocksProduct.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public string ProdName { get; set; }
        public string CatName { get; set; }
        public decimal ProdPrice { get; set; }
        public decimal TotalCost { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}