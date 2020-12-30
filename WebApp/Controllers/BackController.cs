﻿using System;
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

        [HttpPost]

        public ActionResult UpvoteQ(string data)
        {
            string[] words = data.Split(' ');
            int userId = int.Parse(words[1]);
            system.UpvoteQuestion(words[0], userId);
            return PartialView("_Partial");
        }

        public ActionResult RemoveUpvoteQ(string data)
        {
            string[] words = data.Split(' ');
            int userId = int.Parse(words[1]);
            system.RemoveUpvoteQ(words[0], userId);
            return PartialView("_Partial");
        }
    }
}