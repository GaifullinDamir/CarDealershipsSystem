using CarDealershipsSystem.DAL.Interfaces;
using CarDealershipsSystem.Domain;

namespace CarDealershipsSystem.DAL.Repositories
{
    public class ManagerUserRepository : IManagerUserRepository
    {
        private readonly CarDealershipsDbContext _context;
        public ManagerUserRepository(CarDealershipsDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ManagerUser> GetManagerUsers()
        {
            var managerUsers = _context.ManagerUsers.ToList();
            return managerUsers;
        }
    }
}
