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
            var carsDTO = cars
                .Select(car => new CarDTO
            {
                IdCar = car.IdCar,
                IdBranch = car.IdBranch,
                Brand = car.Brand,
                Model = car.Model,
                BodyType = car.BodyType,
                Quantity = car.Quantity,
                CarExemplars = car.CarExemplars
                    .Select(carex => new CarExemplarDTO
                    {
                        VinNumber = carex.VinNumber,
                        IdCar = carex.IdCar,
                        HorsePower = carex.HorsePower,
                        Price = carex.Price,
                        Color = carex.Color,
                        YearOfAssembly = carex.YearOfAssembly
                    })
                    .ToList()
            });
            return carsDTO;
        }
    }
}
