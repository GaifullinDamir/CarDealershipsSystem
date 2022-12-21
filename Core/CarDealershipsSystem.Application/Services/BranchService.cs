using CarDealershipsSystem.Application.DTO;
using CarDealershipsSystem.Application.Interfaces;
using CarDealershipsSystem.DAL;
using CarDealershipsSystem.DAL.Interfaces;
using CarDealershipsSystem.Domain;

namespace CarDealershipsSystem.Application.Services
{
    public class BranchService : IBranchService
    {
        private readonly IBranchRepository _branchRepository;
        private readonly ICarRepository _carRepository;
        public BranchService(IBranchRepository branchRepository, ICarRepository carRepository)
        {
            _branchRepository = branchRepository;
            _carRepository = carRepository;
        }
        public IEnumerable<BranchDTO> GetBranches()
        {
            var branches = _branchRepository.GetBranches();
            var branchesDTO = branches
                .Select(branch => new BranchDTO
                {
                IdBranch = branch.IdBranch,
                BranchName = branch.BranchName,
                BranchAddress = branch.BranchAddress,
                IdHead = branch.IdHead,
                Cars = branch.Cars
                .Select(car => new CarDTO
                {
                    IdCar = car.IdCar,
                    IdBranch = car.IdBranch,
                    Brand = car.Brand,
                    Model = car.Model,
                    BodyType = car.BodyType,

                    CarExemplars = car.CarExemplars
                    .Select(carex => new CarExemplarDTO
                    {
                        VinNumber = carex.VinNumber,
                        IdCar = carex.IdCar,
                        HorsePower = carex.HorsePower,
                        Price = carex.Price,
                        Color = carex.Color,
                        YearOfAssembly = carex.YearOfAssembly
                    })
                    .ToList()
                })
                .ToList(),
                Managers = branch.Managers
                .Select(manager => new ManagerDTO
                {
                    MngrPassData = manager.MngrPassData,
                    IdBranch = manager.IdBranch,
                    MngrSurname = manager.MngrSurname,
                    MngrName =  manager.MngrName,
                    MngrMiddlename = manager.MngrMiddlename,
                    MngrPhoneNumber = manager.MngrPhoneNumber,
                    MngrSalary = manager.MngrSalary,
                    MngrPayDate = manager.MngrPayDate,
                    MngrPrize = manager.MngrPrize,
                    CarOrders = manager.CarOrders
                    .Select(carorder => new CarOrderDTO
                    {
                        IdOrder = carorder.IdOrder,
                        IdMngr = carorder.IdMngr,
                        IdBuyer = carorder.IdBuyer,
                        ContractDate = carorder.ContractDate,
                        OrderAmount = carorder.OrderAmount
                    })
                    .ToList()
                })
                .ToList()
            }) ;
            return branchesDTO;
        }

        public bool AddBranch(string branchName, string branchAddress, int idHead)
        {
            var branch = new Branch()
            {
                BranchName = branchName,
                BranchAddress = branchAddress,
                IdHead = idHead
            };
            if (_branchRepository.SaveBranch(branch))
            {
                return true;
            }
            return false;
        }

        public bool IsBranchExistsById(int idBranch)
        {
            if (_branchRepository.GetBranchById(idBranch) != null) { return true; }
            return false;
        }
        public IEnumerable<BranchDTO> SearchBranch(string branchName)
        {
            var branches = _branchRepository.GetBranchesByName(branchName);
            var branchesDTO = branches.Select(branch => new BranchDTO()
            {
                IdBranch = branch.IdBranch,
                BranchName = branch.BranchName,
                BranchAddress = branch.BranchAddress,
                IdHead = branch.IdHead,
                Cars = branch.Cars
                .Select(car => new CarDTO
                {
                    IdCar = car.IdCar,
                    IdBranch = car.IdBranch,
                    Brand = car.Brand,
                    Model = car.Model,
                    BodyType = car.BodyType,

                    CarExemplars = car.CarExemplars
                    .Select(carex => new CarExemplarDTO
                    {
                        VinNumber = carex.VinNumber,
                        IdCar = carex.IdCar,
                        HorsePower = carex.HorsePower,
                        Price = carex.Price,
                        Color = carex.Color,
                        YearOfAssembly = carex.YearOfAssembly
                    })
                    .ToList()
                })
                .ToList(),
                Managers = branch.Managers
                .Select(manager => new ManagerDTO
                {
                    MngrPassData = manager.MngrPassData,
                    IdBranch = manager.IdBranch,
                    MngrSurname = manager.MngrSurname,
                    MngrName = manager.MngrName,
                    MngrMiddlename = manager.MngrMiddlename,
                    MngrPhoneNumber = manager.MngrPhoneNumber,
                    MngrSalary = manager.MngrSalary,
                    MngrPayDate = manager.MngrPayDate,
                    MngrPrize = manager.MngrPrize,
                    CarOrders = manager.CarOrders
                    .Select(carorder => new CarOrderDTO
                    {
                        IdOrder = carorder.IdOrder,
                        IdMngr = carorder.IdMngr,
                        IdBuyer = carorder.IdBuyer,
                        ContractDate = carorder.ContractDate,
                        OrderAmount = carorder.OrderAmount
                    })
                    .ToList()
                })
                .ToList()
            });
            return branchesDTO;

        
        }
    }
}
