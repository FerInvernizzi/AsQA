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
            return View();
        }
    }
}