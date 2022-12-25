using CarDealershipsSystem.DAL.Interfaces;
using CarDealershipsSystem.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarDealershipsSystem.DAL.Repositories
{
    public class CarOrderRepository : ICarOrderRepository
    {
        private readonly CarDealershipsDbContext _context;
        public CarOrderRepository(CarDealershipsDbContext context)
        {
            _context = context;
        }

        public IEnumerable<CarOrder> GetCarOrders()
        {
            var carOrders = _context.CarOrders
                .ToList();
            return carOrders;
        }

        public bool SaveCarOrder(CarOrder carOrder)
        {
            if (carOrder == null)
            {
                return false;
            }

            _context.Add(carOrder);
            return _context.SaveChanges() > 0 ? true : false;
        }
    }
}
