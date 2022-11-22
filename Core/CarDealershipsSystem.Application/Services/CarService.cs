using CarDealershipsSystem.Application.DTO;
using CarDealershipsSystem.Application.Interfaces;
using CarDealershipsSystem.DAL.Interfaces;

namespace CarDealershipsSystem.Application.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public IEnumerable<CarDTO> GetCars()
        {
            var cars = _carRepository.GetCars();
            var carsDTO = cars.Select(car => new CarDTO
            {
                IdCar
            });
        }
    }
}
