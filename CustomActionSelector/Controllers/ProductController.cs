using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomActionSelector.Controllers
{
    public class ProductController : Controller
    {
        public class Product
        {
            public string ProductName { get; set; }
            public int UnitPrice { get; set; }
        }
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetAll()
        {
            var products = new List<Product>
                {
                new Product
                {
                    ProductName="Laptop",
                    UnitPrice=8960
                },
                new Product
                {
                    ProductName="Masaüstü",
                    UnitPrice=7600
                }
            };
            return Json(products, JsonRequestBehavior.AllowGet);
        }
    }
}