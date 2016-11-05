using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WarlocksProduct.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }
        public string EmailId { get; set; }
        public char Mobile { get; set; }
    }
}