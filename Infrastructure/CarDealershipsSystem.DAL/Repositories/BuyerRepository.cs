using CarDealershipsSystem.DAL.Interfaces;
using CarDealershipsSystem.Domain;

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
            var buyers = _context.Buyers.ToList();
            return (IEnumerable<Buyer>)buyers;
        }
    }
}
