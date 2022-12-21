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

        public BranchRepository(CarDealershipsDbContext context,
            ICarRepository carRepository)
        {
            _context = context;
            _carRepository = carRepository;
        }

        //public IEnumerable<Branch> GetBranches()
        //{
        //    var branches = _context.Branches
        //        .Include(branch => branch.Cars.Join(_context.CarExemplars
        //        , c => c.IdCar
        //        , ce => ce.IdCar,
        //        (c, ce) => new()
        //        {
        //            IdCar = c.IdCar,
        //            IdBranch = c.IdBranch,
        //            IdBranchNavigation = c.IdBranchNavigation,
        //            BodyType = c.BodyType,
        //            Brand = c.Brand,
        //            Model = c.Model,
        //            CarExemplars = c.CarExemplars,


        //        })

        //    return branches;

        //}
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

            return branches;
        }

        //public IEnumerable<Branch> GetBranches()
        //{
        //    //var branches = _context.Branches
        //    //    .Join(_context.Cars,
        //    //    b => b.IdBranch,
        //    //    c => c.IdBranch)
                
        //    //    //.Include(branch => branch.Managers)
        //    //    //.ToList();
        //    var branches = from branch in _context.Branches
        //                   join cars in _context.Cars on branch.IdBranch equals cars.IdBranch
        //                   join carexemplar in _context.CarExemplars on cars.IdCar equals carexemplar.IdCar
        //                   select new()
        //                   {

        //                   };
        //    return branches;
        //}

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
