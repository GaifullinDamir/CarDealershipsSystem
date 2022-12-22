using CarDealershipsSystem.DAL.Interfaces;
using CarDealershipsSystem.Domain;
using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;


namespace CarDealershipsSystem.DAL.Repositories
{
    public class BranchRepository : IBranchRepository
    {
        private readonly CarDealershipsDbContext _context;
        private readonly ICarRepository _carRepository;
        private readonly IManagerRepository _managerRepository;

        public BranchRepository(CarDealershipsDbContext context,
            ICarRepository carRepository,
            IManagerRepository managerRepository)
        {
            _context = context;
            _carRepository = carRepository;
            _managerRepository = managerRepository;
        }

        public IEnumerable<Branch> GetBranches()
        {
            var branches = _context.Branches
                .Include(branch => branch.Cars)
                .Include(branch => branch.Managers)
                .ToList();
            return branches;
        }

        public IEnumerable<Branch> GetBranchesWithCarsExemplars()
        {
            var branches = _context.Branches
                .Include(branch => branch.Cars)
                .Include(branch => branch.Managers)
                .ToList();
            var cars = _carRepository.GetCars().ToList();
            var managers = _managerRepository.GetManagers().ToList();

            return branches;
        }


        public Branch GetBranchById(int idBranch)
        {
            var branch = _context.Branches
                .Where(b => b.IdBranch == idBranch)
                .Include(b => b.Cars)
                .Include(b => b.Managers)
                .FirstOrDefault();
            if (branch != null)
            {
                var cars = _carRepository.GetCars().ToList();
                var managers = _managerRepository.GetManagers().ToList();
            }

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
