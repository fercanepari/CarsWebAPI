using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarsWebAPI.Domain.Entities;
using CarsWebAPI.Domain.Repositories;
using CarsWebAPI.Domain.Services;

namespace CarsWebAPI.Application.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public IEnumerable<Car> GetAllCars()
        {
            return _carRepository.GetAllCars();
        }

        public Car GetCarById(int carId)
        {
            return _carRepository.GetCarById(carId);
        }

        public void AddCar(Car car)
        {
            _carRepository.AddCar(car);
        }

        public void UpdateCar(Car car)
        {
            _carRepository.UpdateCar(car);
        }

        public void DeleteCar(int carId)
        {
            _carRepository.DeleteCar(carId);
        }
    }
}
