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

        public bool AddManager(string mngrPassData, string idBranch, string mngrSurname,
            string mngrName, string mngrMiddlename, string mngrPhoneNumber,
            string mngrSalary, string mngrPayDate, string managerPassword,
            string managerLogin)
        {
            int intIdBranch = 0;
            try
            {
                intIdBranch = Convert.ToInt32(idBranch);
            }
            catch (Exception)
            {
                return false;
            }

            _branch
            var manager = new Manager()
            {
                MngrPassData = mngrPassData,
                IdBranch = idBranch, //сделай проверку, есть ли такая бранча
                MngrSurname = mngrSurname,
                MngrName = mngrName,
                MngrMiddlename = mngrMiddlename,
                MngrPhoneNumber = mngrPhoneNumber,
                MngrSalary = mngrSalary,
                MngrPayDate = mngrPayDate,
                ManagerPassword = managerPassword,
                ManagerLogin = managerLogin
            };
        }
    }
}
