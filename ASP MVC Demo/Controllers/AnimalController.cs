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
        public string Index()
        {
            return "This is my <b>default</b> action";
        }

        /// <summary>
        /// GET /Animal/Welcome/
        /// </summary>
        /// <returns></returns>
        public string Welcome(string name, int id = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID is: " + id);
        }
    }
}