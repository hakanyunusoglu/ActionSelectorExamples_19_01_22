using ModelDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelDB.Controllers
{
    public class ProductController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Product
        public ActionResult List()
        {
            MultiModel mm = new MultiModel();
            mm.cList = db.Categories.ToList();
            mm.pList = db.Products.ToList();
            return View(mm);
        }
    }
}