using CoMute.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoMute.Web.Controllers.Web
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User Users)
        {
            using (OurDbContext db = new OurDbContext())
            {
                var usr = db.Users.Single(u => u.Name == Users.Name && u.Password == Users.Password);
                if (usr != null)
                {
                    Session["UserId"] = usr.UserId.ToString();
                    Session["Name"] = usr.Name.ToString();
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "name or password incorrect");
                }
            }

            return View();
        }

        public ActionResult LoggedIn()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User account)

        {
            if (ModelState.IsValid)
            {
                using (OurDbContext db = new OurDbContext())
                {
                    db.Users.Add(account);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = account.Name + "" + account.Surname + "successfully registerd";
            }
            return View();
        }
        public ActionResult CarRegister()
        {
            return View();
        }

        public ActionResult CarsList()
        {
            return View();
        }

        public ActionResult Profile()
        {
            return View();
        }

        public ActionResult UpdateProfile()
        {
            return View();
        }
    }
}