using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebApp_MVC.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TestView() 
        {
            return View();
        }

        public string PrintMessage() 
        {
            return "<h1>Hello world</h1>";
        }

        public string Welcome(string name, int id=1)
        {
            return HttpUtility.HtmlEncode("Hello, " + name + " your ID is " + id);
        }

        public ActionResult ErrorMessage() 
        {
            return View();
        }

       
    }
}