using CarDealershipsSystem.Domain;

namespace CarDealershipsSystem.DAL.Interfaces
{
    public interface ICarExemplarRepository
    {
        IEnumerable<CarExemplar> GetCarExemplars();
    }
}
