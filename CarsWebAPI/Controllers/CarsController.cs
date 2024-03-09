using Microsoft.AspNetCore.Mvc;
using CarsWebAPI.Domain.Entities;
using CarsWebAPI.Domain.Services;

namespace CarsWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public IActionResult GetAllCars()
        {
            var cars = _carService.GetAllCars();
            return Ok(cars);
        }

        [HttpGet("{id}")]
        public IActionResult GetCarById(int id)
        {
            var car = _carService.GetCarById(id);
            if (car == null)
            {
                return NotFound();
            }
            return Ok(car);
        }

        [HttpPost]
        public IActionResult AddCar([FromBody] Car car)
        {
            _carService.AddCar(car);
            return CreatedAtAction(nameof(GetCarById), new { id = car.CarId }, car);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCar(int id, [FromBody] Car car)
        {
            if (id != car.CarId)
            {
                return BadRequest();
            }
            _carService.UpdateCar(car);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCar(int id)
        {
            _carService.DeleteCar(id);
            return NoContent();
        }
    }
}
