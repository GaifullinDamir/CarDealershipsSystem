using CarDealershipsSystem.DAL.Interfaces;
using CarDealershipsSystem.Domain;

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
            var carExemplars = _context.CarExemplars.ToList();
            return carExemplars;
        }
    }
}
