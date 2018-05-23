using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using presurgeryapp.Models;

namespace presurgeryapp.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext ctx = new ApplicationDbContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }

        public IActionResult CreatePatient() {
            var patient = new Patient {
                firstname = "sandun",
                lastname = "ranaweera",
                phone = "(229) 409-9887",
                surgeryDate = "06 June, 2018"
            };
            ctx.patients.Add(patient);
            ctx.SaveChanges();

            return RedirectToAction("ViewPatient");
        }

        public IActionResult ViewPatient() {
            var patient = ctx.patients.First();
            return View(patient);
        }
    }
}
