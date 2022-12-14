using Microsoft.AspNetCore.Mvc;

namespace VehicleAPI.Controllers
{
    public class VehicleController : Controller
    {
        private readonly IVehicleProcessor vehicleProcessor;

        public VehicleController(IVehicleProcessor VehicleProcessor)
        {
            vehicleProcessor = VehicleProcessor;
        }

        [HttpGet("cars/{color}")]
        public async Task<ActionResult<List<Car>>> GetCars(string color)
        {
            var carList = vehicleProcessor.GetCars(color);
            if (carList == null)
                return BadRequest("No cars with color specified.");
            return Ok(carList);
        }

        [HttpGet("buses/{color}")]
        public async Task<ActionResult<List<Bus>>>  GetBuses(string color)
        {
            var busList = vehicleProcessor.GetBuses(color);
            if (busList == null)
                return BadRequest("No buses with color specified.");
            return Ok(busList);
        }

        [HttpGet("boats/{color}")]
        public async Task<ActionResult<List<Boat>>> GetBoats(string color)
        {
            var boatList = vehicleProcessor.GetBoats(color);
            if (boatList == null)
                return BadRequest("No boats with color specified.");
            return Ok(boatList);
        }

        [HttpPost("headlight/{id}")]
        public string SetHeadLight(int id)
        {
            
            vehicleProcessor.SetHeadligtState(id);

            return $"The headlights of the car with {id} is switched if present";
            
        }

        [HttpDelete("deletecar/{id}")]
        public string DeleteCar(int id)
        {
            vehicleProcessor.DeleteCar(id);
            
            return $"The car with {id} is no more in the vehicle list.";

        }
    }
}
