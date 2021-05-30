using Projet.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projet.Net.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        asp_projectEntities users = new asp_projectEntities();
        [HttpPost]
        public ActionResult Login(string username, string mp)
        {
            
            var x = users.admin.ToList();

            if (!string.IsNullOrEmpty(username) && string.IsNullOrEmpty(mp))
            {
                return RedirectToAction("Login");
            }
            foreach(admin ad in x)
            {
                if (ad.username == username && ad.mdp == mp)
                {
                    return View("Index");
                }
            }
            return View();
            
        }
    }
}