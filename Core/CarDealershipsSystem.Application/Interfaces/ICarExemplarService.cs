using CarDealershipsSystem.Application.DTO;

namespace CarDealershipsSystem.Application.Interfaces
{
    public interface ICarExemplarService
    {
        IEnumerable<CarExemplarDTO> GetCarExemplars();

        public bool AddCarExemplar(string vinNumber, int idCar, int horsePower, decimal price,
            string color, DateTime yearOfAssembly, ref string errorMessge);

        public bool IsExistCarExemplarByVinNumber(string vinNumber);

        public CarExemplarDTO GetCarExemplarByVinNumber(string vinNumber);

        public bool DeleteCarExemplar(string vinNumber);
    }
}
