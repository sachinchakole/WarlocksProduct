using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WarlocksProduct.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Category(int id)
        {
            return View();
        }
    }
}