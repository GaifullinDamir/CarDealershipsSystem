using CarDealershipsSystem.Domain;

namespace CarDealershipsSystem.DAL.Interfaces
{
    public interface ICarExemplarRepository
    {
        IEnumerable<CarExemplar> GetCarExemplars();

        public CarExemplar GetCarExemplarByVinNumber(string vinNumber);

        public bool SaveCarExemplar(CarExemplar carExemplar);

        public bool DeleteCarExemplar(CarExemplar carExemplar);

    }
}
