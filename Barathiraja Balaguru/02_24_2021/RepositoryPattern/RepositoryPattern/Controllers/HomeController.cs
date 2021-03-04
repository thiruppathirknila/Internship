using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Infrastructure;
using RepositoryPattern.Models;

namespace RepositoryPattern.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployee _employee;

        public HomeController(IEmployee employee)
        {
            _employee = employee;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var employees = _employee.GetAll();
            return View(employees);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee employee)
        {
            _employee.Insert(employee);
            _employee.Save();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var employee = _employee.GetById(Id);
            return View(employee);
        }

        [HttpPost]
        public IActionResult Delete(Employee employee)
        {
            _employee.Delete(employee);
            _employee.Save();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            var employee = _employee.GetById(Id);
            return View(employee);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var employee = _employee.GetById(Id);
            return View(employee);
        }

        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            _employee.Update(employee);
            _employee.Save();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
