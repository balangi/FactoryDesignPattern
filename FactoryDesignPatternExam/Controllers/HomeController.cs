using FactoryDesignPatternExam.Factories;
using FactoryDesignPatternExam.Models;
using FactoryDesignPatternExam.Vehicles;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FactoryDesignPatternExam.Controllers
{
    public partial class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("Index/{id}")]
        public IActionResult Index(int id)
        {
            var vehicleType = (VehicleType)id;
            Vehicle vehicle;
            switch (vehicleType)
            {
                case VehicleType.Boat:
                    vehicle = new BoatCreator().CreateVehicle();
                    vehicle.AddPassenger(14);
                    break;

                case VehicleType.Bus:
                    vehicle = new BusCreator().CreateVehicle();
                    break;

                default:
                case VehicleType.Car:
                    vehicle = new CarCreator().CreateVehicle();
                    break;
            }

            return Ok(vehicle.Capacity);
        }
    }
}