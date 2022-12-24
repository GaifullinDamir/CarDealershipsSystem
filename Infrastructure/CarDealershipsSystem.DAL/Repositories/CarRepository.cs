using CarDealershipsSystem.DAL.Interfaces;
using CarDealershipsSystem.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarDealershipsSystem.DAL.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarDealershipsDbContext _context;
        private readonly ICarExemplarRepository _carExemplarRepository;
        public CarRepository(CarDealershipsDbContext context,
            ICarExemplarRepository carExemplarRepository)
        {
            _context = context;
            _carExemplarRepository = carExemplarRepository;
        }

        public IEnumerable<Car> GetCars()
        {
            var cars = _context.Cars
                .Include(car => car.CarExemplars)
                .ToList();
            var carExemplars = _carExemplarRepository.GetCarExemplars();
            return cars;
        }

        public bool SaveCar(Car car)
        {
            if (car == null)
            {
                return false;
            }

            _context.Add(car);
            return _context.SaveChanges() > 0 ? true : false;
        }
    }
}
