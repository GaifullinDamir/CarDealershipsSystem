using CarDealershipsSystem.Application.DTO;
using CarDealershipsSystem.Application.Interfaces;
using CarDealershipsSystem.DAL.Interfaces;

namespace CarDealershipsSystem.Application.Services
{
    public class CarExemplarService : ICarExemplarService
    {
        private readonly ICarExemplarRepository _carExemplarRepository;

        public CarExemplarService(ICarExemplarRepository carExemplarRepository)
        {
            _carExemplarRepository = carExemplarRepository;
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
    }
}
