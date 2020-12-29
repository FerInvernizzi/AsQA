using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain;
using Newtonsoft.Json;

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

        public ActionResult Upvote(string data)
        {
            
            string[] words = data.Split();

            int userId = -1;
            foreach(User u in system.Users)
            {
                if(json.name == u.Username)
                {
                    userId = u.Id;
                }
            }
            system.CreateUpvote(id, userId);
            return PartialView("_Partial");
        }
    }
}