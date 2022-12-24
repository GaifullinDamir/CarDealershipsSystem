using CarDealershipsSystem.Application.DTO;
using CarDealershipsSystem.Application.Interfaces;
using CarDealershipsSystem.DAL.Interfaces;
using CarDealershipsSystem.Domain;

namespace CarDealershipsSystem.Application.Services
{
    public class CarExemplarService : ICarExemplarService
    {
        private readonly ICarExemplarRepository _carExemplarRepository;
        private readonly ICarService _carService;

        public CarExemplarService(ICarExemplarRepository carExemplarRepository,
            ICarService carService)
        {
            _carExemplarRepository = carExemplarRepository;
            _carService = carService;
        }

        public IEnumerable<CarExemplarDTO> GetCarExemplars()
        {
            var carExemplars = _carExemplarRepository.GetCarExemplars();
            var carExemplarsDTO = carExemplars
                .Select(carex => new CarExemplarDTO
                {
                    VinNumber = carex.VinNumber,
                    IdCar = carex.IdCar,
                    HorsePower = carex.HorsePower,
                    Price = carex.Price,
                    Color = carex.Color,
                    YearOfAssembly = carex.YearOfAssembly
                }).ToList();
            return carExemplarsDTO;
        }

        public bool AddCarExemplar(string vinNumber, int idCar, int horsePower, decimal price,
            string color, DateTime yearOfAssembly, ref string errorMessage)
        {
            if (!_carService.IsCarExistById(idCar))
            {
                errorMessage = "Такого автомобиля нет.";
                return false;
            }
            if (!IsExistCarExemplarByVinNumber(vinNumber))
            {
                var carExemplar = new CarExemplar()
                {
                    VinNumber = vinNumber,
                    IdCar = idCar,
                    HorsePower = horsePower,
                    Price = price,
                    Color = color,
                    YearOfAssembly = yearOfAssembly
                };
                if (_carExemplarRepository.SaveCarExemplar(carExemplar))
                {
                    return true;
                }
                errorMessage = "Ошибка при добавлении.";
                return false;
            }
            errorMessage = "Автомобиль с таким Vin-номером\nуже есть";
            return false;
        }

        public bool IsExistCarExemplarByVinNumber(string vinNumber)
        {
            var carExemplar = _carExemplarRepository.GetCarExemplarByVinNumber(vinNumber);
            if (carExemplar == null)
            {
                return false;
            }
            return true;
        }
    }
}
