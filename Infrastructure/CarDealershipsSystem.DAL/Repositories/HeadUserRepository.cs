using CarDealershipsSystem.DAL.Interfaces;
using CarDealershipsSystem.Domain;

namespace CarDealershipsSystem.DAL.Repositories
{
    public class HeadUserRepository : IHeadUserRepository
    {
        private readonly CarDealershipsDbContext _context;
        public HeadUserRepository(CarDealershipsDbContext context)
        {
            _context = context;
        }

        public IEnumerable<HeadUser> GetHeadUsers()
        {
            var headUsers = _context.HeadUsers.ToList();
            return headUsers;
        }

        public bool SaveHeadUser(HeadUser headUser)
        {
            if(headUser == null)
            { return false; }

            //_context.HeadUsers.Add(headUser);
            _context.Add(headUser);
            return _context.SaveChanges() > 0 ? true : false;
        }
    }
}
