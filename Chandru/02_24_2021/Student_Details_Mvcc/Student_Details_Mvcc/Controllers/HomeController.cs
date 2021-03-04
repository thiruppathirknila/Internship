using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Student_Details_Mvcc.Models;
using System.Data.Entity;
using System.Security;
using System.Net;

namespace Student_Details_Mvcc.Controllers 
{
    public class HomeController : Controller
    {
        SclDpContext db = new SclDpContext();


        public ActionResult Index()
        {
            return View();
            
        }


        //****Student Registration*******//
       
        [HttpGet]
        public ActionResult stuRegis()
        {

            if (Session["studentId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }

        }
       
        [HttpPost]
        public ActionResult stuRegis(Studentmodel user)
        {
            if (ModelState.IsValid)
            {
                db.Studentmodels.Add(user);
                db.SaveChanges();
                ViewBag.msg = "Student Details Added";
                ModelState.Clear();
                RedirectToAction("CreateDetails");

            }
           
            
            return View();

        }

        //****Student Mark Entry******//

       
        [HttpGet]
        public ActionResult CreateDetails()
        {
            if (Session["studentId"] != null)
            {
                List<Studentmodel> st = db.Studentmodels.Where(e => e.IsActive == true).OrderBy(e => e.RoleNo).ToList();
                ViewBag.StdId = new SelectList(st, "RoleNo", "Std_Name");
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }

           
        }
        
[HttpPost]

        public ActionResult CreateDetails(Markmodel mark)
        {
            if (ModelState.IsValid)

            {
                List<Studentmodel> st = db.Studentmodels.Where(e => e.IsActive == true).OrderBy(e => e.RoleNo).ToList();
                ViewBag.StdId = new SelectList(st, "RoleNo", "Std_Name");
                db.Markmodels.Add(mark);
                db.SaveChanges();
                ViewBag.msg = "StudendDetails Sucessfully Addes";
                ModelState.Clear();
               
            }
            return View();

        }
        //**** Student List View*****//
      
        public ActionResult GetMark()
        {

            using (SclDpContext db = new SclDpContext())
            {

                List<Studentmodel> employees = db.Studentmodels.ToList();
                List<Markmodel> departments = db.Markmodels.ToList();



                var employeeRecord = (from e in employees
                                      join d in departments on e.RoleNo equals d.StdId
                                      orderby d.Total descending

                                      select new Viewmodel
                                      {


                                          employee = e,
                                          department = d,


                                      }).ToList();

                var temp = 0;
                int i = 0;
                int j = 1;
                foreach (var item in employeeRecord)
                {
                    if (item.department.Total != temp)
                    {
                        if (j == 0)
                        {
                            i++;
                        }
                        else
                        {
                            i = i + j;
                            j = 1;
                        }
                        item.Rank = i;

                    }
                    else
                    {
                        item.Rank = i;
                        j = j+1;
                    }

                    temp = item.department.Total;

                };

                return View(employeeRecord);
            }

        }


      
        [HttpGet]
        public ActionResult userRegistration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult userRegistration(UserRegistration user)
        {
            if (ModelState.IsValid)
            {
                var check = db.userRegistrations.FirstOrDefault(e => e.Email == user.Email);
                if (check == null)
                {
                    db.userRegistrations.Add(user);
                    db.SaveChanges();
                    ViewBag.msg = "Registration Sycessfully";
                    ModelState.Clear();
                }
                else
                {
                    ViewBag.error = "Email Id Already Exists";
                }
            }
            return View();

        }

        //*****Student Login********//
        
        [HttpGet]
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
                var data = db.userRegistrations.Where(s => s.Email.Equals(email) && s.Password.Equals(f_password)).ToList();
                if (data.Count() > 0)
                {
                    //add session
                    Session["FullName"] = data.FirstOrDefault().FirstName + " " + data.FirstOrDefault().LastName;
                    Session["Email"] = data.FirstOrDefault().Email;
                    Session["studentId"] = data.FirstOrDefault().studentId;
                    ViewBag.msg = "Login Sucessfully";
                   
                }
                else
                {
                    ViewBag.error = "Login failed";
                    return RedirectToAction("Login");
                }
            }
            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear();//remove session
            return RedirectToAction("Login");
        }


        //***tblstudent****//
        [HttpGet]
        public ActionResult Edit(int?id)
        {
           
            Studentmodel userm = db.Studentmodels.Find(id);
           
            return View(userm);

        }


        [HttpPost]
        public ActionResult Edit(int id)
        {
            if (ModelState.IsValid)
            {
                Studentmodel stu = db.Studentmodels.Find(id);
                UpdateModel(stu);
                db.SaveChanges();
                ViewBag.msg = "Student Updated Sucessfully";
               ModelState.Clear();


            }
            return View();
        }

        //****StudentList View******\\
        public ActionResult studentView()
        {
            return View(db.Studentmodels.ToList());
        }



        // Details Of the Students
        public ActionResult Details(int? id)
        {
           
            Studentmodel _objstu = db.Studentmodels.Find(id);
           
            return View(_objstu);
        }



        //****Student Delete*****\\
        [HttpGet]
        public ActionResult Delete(int?id)
        {
            Studentmodel userm = db.Studentmodels.Find(id);
            return View(userm);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {

            Studentmodel stu = db.Studentmodels.Find(id);

            db.Studentmodels.Remove(stu);
            db.SaveChanges();
            return View(stu);


        }




    }
        }

    