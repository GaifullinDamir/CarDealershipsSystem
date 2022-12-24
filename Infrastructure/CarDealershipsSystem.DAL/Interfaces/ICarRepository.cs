using CarDealershipsSystem.Domain;

namespace CarDealershipsSystem.DAL.Interfaces
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCars();

        public bool SaveCar(Car car);
    }
}
