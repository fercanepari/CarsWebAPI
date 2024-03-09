using CarsWebAPI.Domain.Entities;

namespace CarsWebAPI.Domain.Repositories
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCars();
        Car GetCarById(int carId);
        void AddCar(Car car);
        void UpdateCar(Car car);
        void DeleteCar(int carId);
    }
}
