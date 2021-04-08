using Login_Form.Models;
using Login_Form.Services.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login_Form.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View("Login");
        }

        public ActionResult Login(userModel userModels) 
        {
            // return "Results: User Name = " + userModel.UserName + " PW = " + userModel.Password;
            SecurityService securityService = new SecurityService();
            Boolean success = securityService.Authenticate(userModels);

            if (success)
            {
                return View("LoginSuccess", userModels);

            }
            else
            {
                return View("LoginFailed");
            }
        }
    }
}