using CarDealershipsSystem.DAL.Interfaces;
using CarDealershipsSystem.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarDealershipsSystem.DAL.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarDealershipsDbContext _context;
        public CarRepository(CarDealershipsDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Car> GetCars()
        {
            var cars = _context.Cars
                .Include(car => car.CarExemplars)
                .ToList();
            return cars;
        }
    }
}
