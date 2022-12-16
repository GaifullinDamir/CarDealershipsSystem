using CarDealershipsSystem.DAL.Interfaces;
using CarDealershipsSystem.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarDealershipsSystem.DAL.Repositories
{
    public class ManagerRepository : IManagerRepository
    {
        private readonly CarDealershipsDbContext _context;
        public ManagerRepository(CarDealershipsDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Manager> GetManagers()
        {
            var managers = _context.Managers
                .Include(manager => manager.CarOrders)
                .ToList();
            return managers;
        }
    }
}
