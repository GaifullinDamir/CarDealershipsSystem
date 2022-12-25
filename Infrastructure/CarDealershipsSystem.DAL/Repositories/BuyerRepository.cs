using CarDealershipsSystem.DAL.Interfaces;
using CarDealershipsSystem.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarDealershipsSystem.DAL.Repositories
{
    public class BuyerRepository : IBuyerRepository
    {
        private readonly CarDealershipsDbContext _context;
        private readonly ICarOrderRepository _carOrderRepository;
        public BuyerRepository(CarDealershipsDbContext context,
            ICarOrderRepository carOrderRepository)
        {
            _context = context;
            _carOrderRepository = carOrderRepository;
        }

        public IEnumerable<Buyer> GetBuyers()
        {
            var buyers = _context.Buyers
                .Include(buyer => buyer.CarOrders)
                .ToList();
            var carOrders = _carOrderRepository.GetCarOrders();
            return buyers;
        }

        public Buyer GetBuyerById(int idBuyer)
        {
            var buyer = _context.Buyers
                .Include(buyer => buyer.CarOrders)
                .FirstOrDefault(buyer => buyer.IdBuyer == idBuyer);
                
            var carOrders = _carOrderRepository.GetCarOrders();
            return buyer;
        }
    }
}
