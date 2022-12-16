using CarDealershipsSystem.DAL.Interfaces;
using CarDealershipsSystem.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarDealershipsSystem.DAL.Repositories
{
    public class BuyerRepository : IBuyerRepository
    {
        private readonly CarDealershipsDbContext _context;
        public BuyerRepository(CarDealershipsDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Buyer> GetBuyers()
        {
            var buyers = _context.Buyers
                .Include(buyer => buyer.CarOrders)
                .ToList();
            return buyers;
        }
    }
}
