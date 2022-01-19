using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionSelectorExamples_19_01_22.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //[ActionName("IndexDemo")]
        public ActionResult Index()
        {
            return View();
        }
        //[NonAction]   --> Methodun public olmak zorunda ama aksiyonu olmamasını istiyorsak başına koyuyoruz 
        public string GetConnectionString()
        {
            return "db bağlantısı";
        }

        //[AcceptVerbs(HttpVerbs.Post| HttpVerbs.Get)] //GET ve POST işlemlerine izin vermiş oluyoruz
        //[HttpGet] // Sadece GET işlemlerine izin verir
        //[HttpPost] // Sadece POST işlemlerine izin verir
        public ActionResult something()
        {
            return Content("Aksiyondan Mesaj");
        }

    }
}