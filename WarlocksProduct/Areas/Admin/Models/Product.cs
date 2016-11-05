using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace WarlocksProduct.Areas.Admin.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProdName { get; set; }
        public decimal ProdPrice { get; set; }
        public string ProdImage { get; set; }
        public string ProdDesciption { get; set; }

        public Category CategoryId { get; set; }    
    }
}