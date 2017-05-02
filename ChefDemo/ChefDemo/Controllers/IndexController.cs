using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChefDemo.Controllers
{
    public class IndexController : Controller
    {
        //
        // GET: /Index/

        public ActionResult Index()
        {
            ViewBag.ChefValue = ConfigurationManager.AppSettings["ChefValue"];
            var model = new ChefDemo.Service.Index().Get();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(ChefDemo.Models.Index index)
        {
            ViewBag.Name = index.FirstName;
            return View("Done");
        }

    }
}
