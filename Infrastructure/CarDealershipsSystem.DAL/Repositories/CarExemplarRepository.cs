using CarDealershipsSystem.DAL.Interfaces;
using CarDealershipsSystem.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarDealershipsSystem.DAL.Repositories
{
    public class CarExemplarRepository : ICarExemplarRepository
    {
        private readonly CarDealershipsDbContext _context;
        public CarExemplarRepository(CarDealershipsDbContext context)
        {
            _context = context;
        }

        public IEnumerable<CarExemplar> GetCarExemplars()
        {
            var carExemplars = _context.CarExemplars
                .Include(carExemplar => carExemplar.CarOrder)
                .ToList();
            return carExemplars;
        }
    }
}
