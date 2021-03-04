using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvcstudentdetails.Models;

namespace Mvcstudentdetails.Controllers
{
    public class HomeController : Controller
    {
        StudentDbContext db = new StudentDbContext();

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(ModelStudent student)
        {
            if (ModelState.IsValid)
            {
                db.ModelStudents.Add(student);
                db.SaveChanges();
                ModelState.Clear();
               
            }
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string email, string password)
        {
            if (ModelState.IsValid)
            {


                var f_password = password;
                var data = db.ModelStudents.Where(s => s.Email.Equals(email) && s.Password.Equals(f_password)).ToList();
                if (data.Count() > 0)
                {
                    //add session
                    Session["FullName"] = data.FirstOrDefault().Name;
                    Session["Email"] = data.FirstOrDefault().Email;
                    Session["Std_id"] = data.FirstOrDefault().Std_id;
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.error = "Login failed";
                    return RedirectToAction("Login");
                }
            }
            return View();
        }

        public ActionResult Index()
        {
            if (Session["Std_id"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

    }
}