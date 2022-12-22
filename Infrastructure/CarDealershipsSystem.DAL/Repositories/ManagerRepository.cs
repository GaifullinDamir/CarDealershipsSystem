using CarDealershipsSystem.DAL.Interfaces;
using CarDealershipsSystem.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarDealershipsSystem.DAL.Repositories
{
    public class ManagerRepository : IManagerRepository
    {
        private readonly CarDealershipsDbContext _context;
        private readonly ICarOrderRepository _carOrderRepository;
        public ManagerRepository(CarDealershipsDbContext context,
            ICarOrderRepository carOrderRepository)
        {
            _context = context;
            _carOrderRepository = carOrderRepository;
        }

        public IEnumerable<Manager> GetManagers()
        {
            var managers = _context.Managers
                .Include(manager => manager.CarOrders)
                .ToList();
            var carOrders = _carOrderRepository.GetCarOrders();
            return managers;
        }

        public bool SaveManager(Manager manager)
        {
            if (manager == null)
            {
                return false;
            }
            _context.Add(manager);
            return _context.SaveChanges() > 0 ? true : false;
        }

        public Manager GetManagerByPassData(string mngrPassData)
        {
            var manager = _context.Managers
                .Include(manager => manager.CarOrders)
                .FirstOrDefault(manager => manager.MngrPassData == mngrPassData);
            var carOrders = _carOrderRepository.GetCarOrders();
            return manager;
        }
    }
}
