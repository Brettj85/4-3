using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo_4_3.Models;
using Microsoft.AspNetCore.Mvc;

namespace demo_4_3.Controllers
{
    public class HomeController : Controller
    {
        private List<Vehicle> Vehicles = new List<Vehicle>()
        {
            new Vehicle {color = "red", Model = "Cruze", NumberOfWheels = 4, vin = 123456}
        };
        public IActionResult Index()
        {
            //ViewBag.Vehicles = Vehicles;
            return View(Vehicles);
        }
    }
}