using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class SignUPController : Controller
    {
        //
        // GET: /SignUP/

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SignUP()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUP(SignUP SignUP)
        {
            return View();
        }

        public ActionResult NavigateTOLogin()
        {
            return RedirectToAction("Login", "Login");
        }
        
	}
}