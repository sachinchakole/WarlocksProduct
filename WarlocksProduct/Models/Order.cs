using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Antlr.Runtime;

namespace WarlocksProduct.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public decimal OrderCost { get; set; }
        public bool SendMail { get; set; }
        public bool SendSms { get; set; }
        public DateTime OrderDate { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
    }
    
}