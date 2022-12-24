using CarDealershipsSystem.DAL.Interfaces;
using CarDealershipsSystem.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarDealershipsSystem.DAL.Repositories
{
    public class CarExemplarRepository : ICarExemplarRepository
    {
        private readonly CarDealershipsDbContext _context;
        private readonly CarOrderRepository _carOrderRepository;
        public CarExemplarRepository(CarDealershipsDbContext context,
            CarOrderRepository carOrderRepository)
        {
            _context = context;
            _carOrderRepository = carOrderRepository;
        }

        public IEnumerable<CarExemplar> GetCarExemplars()
        {
            var carExemplars = _context.CarExemplars
                .Include(carEx => carEx.CarOrder)
                .ToList();
            var carOrders = _carOrderRepository.GetCarOrders();
            return carExemplars;
        }

        public CarExemplar GetCarExemplarByVinNumber(string vinNumber)
        {
            var carExemplar = _context.CarExemplars
                .Include(carEx => carEx.CarOrder)
                .FirstOrDefault(carEx => carEx.VinNumber == vinNumber);
                var carOrders = _carOrderRepository.GetCarOrders();
            return carExemplar;
        }

        public bool SaveCarExemplar(CarExemplar carExemplar)
        {
            if (carExemplar == null)
            {
                return false;
            }
            _context.Add(carExemplar);
            return _context.SaveChanges() > 0 ? true : false;
        }
    }
}
