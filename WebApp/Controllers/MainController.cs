using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain;


namespace WebApp.Controllers
{
    public class MainController : Controller
    {
        Admin system = Admin.Instance;

        // GET: Main
        public ActionResult Index()
        {
            ViewBag.loggedIn = system.LoggedUser;
            ViewBag.questions = system.Questions;
            ViewBag.users = system.Users;
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}