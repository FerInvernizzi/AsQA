using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain;

namespace WebApp.Controllers
{
    public class BackController : Controller
    {
        Admin system = Admin.Instance;
        // GET: Back
        public ActionResult TryLogin(string username, string password)
        {
            foreach(User u in system.Users)
            {
                if(u.Username == username && u.Password == password)
                {
                    system.Login(u);
                    return RedirectToAction("Index", "Main");
                }
            }
            return RedirectToAction("Login", "Main");
        }

        public ActionResult Logout()
        {
            system.Logout();
            return RedirectToAction("Index", "Main");
        }
    }
}