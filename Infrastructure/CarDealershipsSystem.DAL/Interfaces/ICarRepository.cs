using CarDealershipsSystem.Domain;

namespace CarDealershipsSystem.DAL.Interfaces
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCars();
    }
}
