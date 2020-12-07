using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AnimalAppointmentHelper.Models;

namespace AnimalAppointmentHelper.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        IList<Appointments> appointmentsList = new List<Appointments>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult AboutUs()
        {
            return View();
        }

        public ActionResult Results()
        {
            return View();
        }

        
        public ActionResult Appointments(Appointments appointment)
        {
            return View();

        }

        public ActionResult ViewAppointments()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ViewAppointments(string name, string month, string day, string time, string symptoms)
        {
            ViewBag.Name = name;
            ViewBag.Month = month;
            ViewBag.Day = day;
            ViewBag.Time = time;
            ViewBag.Symptoms = symptoms;

            
            appointmentsList.Add(new Appointments() { Name = name, Month = month, Day = day, Time = time, Symptoms = symptoms });
            //ViewData["appointments"] = appointmentsList;
            ViewBag.Appointments = appointmentsList;
            
            return View();
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
