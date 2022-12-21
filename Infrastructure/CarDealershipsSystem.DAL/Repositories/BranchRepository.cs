using CarDealershipsSystem.DAL.Interfaces;
using CarDealershipsSystem.Domain;
using Microsoft.EntityFrameworkCore;

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
            var branches = _context.Branches
                .Include(branch => branch.Cars)
                .Include(branch => branch.Managers)
                .ToList();
            return branches;
        }

        public Branch GetBranchById(int idBranch)
        {
            var branch = _context.Branches
                .Where(b => b.IdBranch == idBranch)
                .Include(b => b.Cars)
                .Include(b => b.Managers)
                .FirstOrDefault();
            return branch;
        }

        public IEnumerable<Branch> GetBranchesByName(string branchName)
        {
            var branches = _context.Branches
                .Where(b => b.BranchName == branchName)
                .Include(b => b.Cars)
                .Include(b => b.Managers)
                .ToList();
            return branches;
        }

        public bool SaveBranch(Branch branch)
        {
            if (branch == null)
            {
                return false;
            }

            _context.Add(branch);
            return _context.SaveChanges() > 0 ? true : false;
        }
    }
}
