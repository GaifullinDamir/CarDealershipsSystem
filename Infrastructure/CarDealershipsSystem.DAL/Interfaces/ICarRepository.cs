using CarDealershipsSystem.Domain;

namespace CarDealershipsSystem.DAL.Interfaces
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCars();

        public Car GetById(int id);

        public bool SaveCar(Car car);

        public bool DeleteCar(Car car);
    }
}
