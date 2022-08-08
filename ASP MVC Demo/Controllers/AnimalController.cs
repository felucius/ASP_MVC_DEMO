using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_MVC_Demo.Controllers
{
    public class AnimalController : Controller
    {
        // GET: /Animal
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// GET /Animal/Welcome/
        /// </summary>
        /// <returns></returns>
        public ActionResult Welcome(string name, int id = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.Id = id;

            return View();
        }
    }
}