using ModelDB2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelDB2.Controllers
{
    public class CustomersController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Customers
        public ActionResult List()
        {
            MultiClass mc = new MultiClass();
            mc.cList = db.Customers.ToList();
            mc.eList = db.Employees.ToList();
            return View(mc);
        }
    }
}