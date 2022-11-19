using CarDealershipsSystem.DAL.Interfaces;
using CarDealershipsSystem.Domain;

namespace CarDealershipsSystem.DAL.Repositories
{
    public class BranchRepository : IBranchRepository
    {
        private readonly CarDealershipsDbContext _context;

        public BranchRepository(CarDealershipsDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Branch> GetBranches()
        {
            var branches = _context.Branches.ToList();
            return branches;
        }
    }
}
