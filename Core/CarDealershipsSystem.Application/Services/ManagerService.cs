using CarDealershipsSystem.Application.DTO;
using CarDealershipsSystem.Application.Interfaces;
using CarDealershipsSystem.DAL.Interfaces;

namespace CarDealershipsSystem.Application.Services
{
    public class ManagerService : IManagerService
    {
        private readonly IManagerRepository _managerServiceRepository;
        public ManagerService(IManagerRepository managerServiceRepository)
        {
            _managerServiceRepository = managerServiceRepository;
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
    }
}
