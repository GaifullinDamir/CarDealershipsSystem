using CarDealershipsSystem.Application.DTO;
using CarDealershipsSystem.Application.Interfaces;
using CarDealershipsSystem.DAL.Interfaces;
using CarDealershipsSystem.Domain;

namespace CarDealershipsSystem.Application.Services
{
    public class ManagerService : IManagerService
    {
        private readonly IManagerRepository _managerRepository;
        private readonly IBranchService _branchService;
        public ManagerService(IManagerRepository managerRepository,
            IBranchService branchService)
        {
            _managerRepository = managerRepository;
            _branchService = branchService;
        }

        public IEnumerable<ManagerDTO> GetManagers()
        {
            var managers = _managerRepository.GetManagers();
            var managersDTO = managers
                .Select(manager => new ManagerDTO
                {
                    IdMngr = manager.IdMngr,
                    MngrPassData = manager.MngrPassData,
                    IdBranch = manager.IdBranch,
                    MngrSurname = manager.MngrSurname,
                    MngrName = manager.MngrName,
                    MngrMiddlename = manager.MngrMiddlename,
                    MngrPhoneNumber = manager.MngrPhoneNumber,
                    MngrSalary = manager.MngrSalary,
                    MngrPayDate = manager.MngrPayDate,
                    MngrPrize = manager.MngrPrize,
                    ManagerPassword = manager.ManagerPassword,
                    ManagerLogin = manager.ManagerLogin,
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
                });
            return managersDTO;
        }

        public bool AddManager(string mngrPassData, int idBranch, string mngrSurname,
            string mngrName, string mngrMiddlename, string mngrPhoneNumber,
            decimal mngrSalary, DateTime mngrPayDate, string managerPassword,
            string managerLogin)
        {
            
            if (!_branchService.IsBranchExistsById(idBranch))
            {
                return false;
            }
            var manager = new Manager()
            {
                MngrPassData = mngrPassData,
                IdBranch = idBranch,
                MngrSurname = mngrSurname,
                MngrName = mngrName,
                MngrMiddlename = mngrMiddlename,
                MngrPhoneNumber = mngrPhoneNumber,
                MngrSalary = mngrSalary,
                MngrPayDate = mngrPayDate,
                ManagerPassword = managerPassword,
                ManagerLogin = managerLogin
            };
            if (_managerRepository.SaveManager(manager))
            {
                return true;
            }
            return false;
        }

        public bool IsManagerDataNotUnique(string mngrPassData, string mngrPhoneNumber, string managerLogin, string managerPassword)
        {
            var managers = GetManagers();
            foreach (var manager in managers)
            {
                if (mngrPassData == manager.MngrPassData||
                    mngrPhoneNumber == manager.MngrPhoneNumber ||
                    managerLogin == manager.ManagerLogin ||
                    managerPassword == manager.ManagerPassword)
                {
                    return true;
                }
            }
            return false;
        }

        public ManagerDTO GetManagerByPassData(string mngrPassData)
        {
            var manager = _managerRepository.GetManagerByPassData(mngrPassData);
            var managerDTO = new ManagerDTO()
            {
                IdMngr = manager.IdMngr,
                MngrPassData = manager.MngrPassData,
                IdBranch = manager.IdBranch,
                MngrSurname = manager.MngrSurname,
                MngrName = manager.MngrName,
                MngrMiddlename = manager.MngrMiddlename,
                MngrPhoneNumber = manager.MngrPhoneNumber,
                MngrSalary = manager.MngrSalary,
                MngrPayDate = manager.MngrPayDate,
                MngrPrize = manager.MngrPrize,
                ManagerPassword = manager.ManagerPassword,
                ManagerLogin = manager.ManagerLogin,
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
            };
            return managerDTO;
        }
    }
}
