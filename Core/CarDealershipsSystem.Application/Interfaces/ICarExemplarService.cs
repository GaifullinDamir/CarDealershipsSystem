using CarDealershipsSystem.Application.DTO;

namespace CarDealershipsSystem.Application.Interfaces
{
    public interface ICarExemplarService
    {
        IEnumerable<CarExemplarDTO> GetCarExemplars();

        public bool AddCarExemplar(string vinNumber, int idCar, int horsePower, decimal price,
            string color, DateTime yearOfAssembly);
    }
}
