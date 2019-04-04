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
        private List<Vehicle> vehicles = new List<Vehicle>()
        {
            new Vehicle {Color = "red", Model = "Cruze", NumberOfWheels = 4, Vin = 123456}
        };
        
        public IActionResult Index()
        {
            //ViewBag.Vehicles = Vehicles;
            return View(vehicles);
        }

        [HttpPost]
        public IActionResult AddVehicle(Vehicle newVehicle)
        {
            vehicles.Add(newVehicle);
            return View("Index", vehicles);
        }
    }
}