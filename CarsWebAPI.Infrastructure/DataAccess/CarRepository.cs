using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using CarsWebAPI.Domain.Entities;
using CarsWebAPI.Domain.Repositories;

namespace CarsWebAPI.Infrastructure.DataAccess
{
    public class CarRepository : ICarRepository
    {
        private readonly CarsDbContext _context;

        public CarRepository(CarsDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Car> GetAllCars()
        {
            return _context.Cars.ToList();
        }

        public Car GetCarById(int carId)
        {
            return _context.Cars.FirstOrDefault(c => c.CarId == carId);
        }

        public void AddCar(Car car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();
        }

        public void UpdateCar(Car car)
        {
            var existingCar = _context.Cars.Find(car.CarId);
            if (existingCar != null)
            {
                existingCar.Year = car.Year;
                existingCar.Maker = car.Maker;
                existingCar.Model = car.Model;
                existingCar.Submodel = car.Submodel;
                _context.SaveChanges();
            }
        }

        public void DeleteCar(int carId)
        {
            var carToDelete = _context.Cars.Find(carId);
            if (carToDelete != null)
            {
                _context.Cars.Remove(carToDelete);
                _context.SaveChanges();
            }
        }
    }
}
