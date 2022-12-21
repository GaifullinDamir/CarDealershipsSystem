using CarDealershipsSystem.Application.DTO;
using CarDealershipsSystem.Application.Interfaces;
using CarDealershipsSystem.DAL.Interfaces;
using CarDealershipsSystem.Domain;

namespace CarDealershipsSystem.Application.Services
{
    public class ManagerService : IManagerService
    {
        private readonly IManagerRepository _managerServiceRepository;
        private readonly IBranchService _branchService;
        public ManagerService(IManagerRepository managerServiceRepository,
            IBranchService branchService)
        {
            _managerServiceRepository = managerServiceRepository;
            _branchService = branchService;
        }

        public IEnumerable<ManagerDTO> GetManagers()
        {
            var managers = _managerServiceRepository.GetManagers();
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
            

            var IsBranchExist = _branchService.IsBranchExistsById(idBranch);

            

            

            var manager = new Manager()
            {
                MngrPassData = mngrPassData,
                IdBranch = iddBranch,
                MngrSurname = mngrSurname,
                MngrName = mngrName,
                MngrMiddlename = mngrMiddlename,
                MngrPhoneNumber = mngrPhoneNumber,
                MngrSalary = decMngrSalary,
                MngrPayDate = mngrPayDate,
                ManagerPassword = managerPassword,
                ManagerLogin = managerLogin
            };
        }
    }
}
