using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace CustomActionSelector.Controllers
{
    public class Product
    {
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
    }
    public class ProductController : Controller
    {       
        public class AjaxMethodAttribute : ActionMethodSelectorAttribute
        {
            public override bool IsValidForRequest(ControllerContext controllerContext, MethodInfo methodInfo)
            {
                return controllerContext.HttpContext.Request.IsAjaxRequest();
            }
        }
        public ActionResult Index()
        {
            return View();
        }
        [AjaxMethod]
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