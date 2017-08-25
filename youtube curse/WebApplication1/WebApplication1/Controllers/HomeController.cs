using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "hELLOR wORLD";//View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}