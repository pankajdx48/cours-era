using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [ActionName("Login")]
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            //if (IsValid(userr.Email, userr.Password))
            //{
            //    FormsAuthentication.SetAuthCookie(userr.Email, false);
            //    return RedirectToAction("Index", "Home");
            //}
            //else
            //{
            //    ModelState.AddModelError("", "Login details are wrong.");
            //}
            //return View(userr); 
            return View(); 
        }
	}
}