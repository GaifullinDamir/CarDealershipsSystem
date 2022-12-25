using CarDealershipsSystem.Application.DTO;
using CarDealershipsSystem.Application.Interfaces;
using CarDealershipsSystem.DAL.Interfaces;
using CarDealershipsSystem.Domain;
using System.Globalization;

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
            ManagerDTO managerDTO = null;
            if (manager != null)
            {
                managerDTO= new ManagerDTO()
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
            }
            
            return managerDTO;
        }

        public bool ManagerChangeData(string option, string mngrPassData, string data, ref string errorMessage)
        {
            var manager = _managerRepository.GetManagerByPassData(mngrPassData);

            if (option == "Имя")
            {
                if (data.Length > 30)
                {
                    return false;
                }
                manager.MngrName = data;
            }
            else if (option == "Фамилия")
            {
                if (data.Length > 30)
                {
                    return false;
                }   
                manager.MngrSurname = data;
            }
            else if (option == "Отчество")
            {
                if (data.Length > 30)
                {
                    return false;
                }
                manager.MngrMiddlename = data;
            }
            else if (option == "Паспортные данные")
            {
                if (data.Length > 20)
                {
                    return false;
                }
                manager.MngrPassData = data;
            }
            else if (option == "Номер телефона")
            {
                if (data.Length > 20)
                {
                    return false;
                }
                manager.MngrPhoneNumber = data;
            }
            else if (option == "Логин")
            {
                if (data.Length > 20)
                {
                    return false;
                }
                manager.ManagerLogin = data;
            }
            else if (option == "Пароль")
            {
                if (data.Length > 20)
                {
                    return false;
                }
                manager.ManagerPassword = data;
            }
            else if (option == "Дата зарплаты")
            {
                try
                {
                    var dateMngrPayDate = DateTime.Parse(data);
                    manager.MngrPayDate = dateMngrPayDate;

                }
                catch (Exception)
                {
                    errorMessage = "Формат записи даты:\n" +
                        "yyyy.mm.dd\n" +
                        "mm.dd.yyyy\n" +
                        "yyyy-mm-dd\n" +
                        "yyyy/mm/dd";
                    return false;
                }
            }
            else if (option == "Зарплата")
            {
                if (!data.Contains(','))
                {
                    var decMngrSalary = Decimal.Parse(data, CultureInfo.InvariantCulture);
                    manager.MngrSalary = decMngrSalary;
                }
                else
                {
                    errorMessage = "Разедлителем между целой частью числа\n и десятичной должна быть точка ('.')";
                    return false;
                }
            }
            else if (option == "Премия")
            {
                if (!data.Contains(','))
                {
                    var decMngrPrize = Decimal.Parse(data, CultureInfo.InvariantCulture);
                    manager.MngrPrize = decMngrPrize;
                }
                else
                {
                    errorMessage = "Разедлителем между целой частью числа\n и десятичной должна быть точка ('.')";
                    return false;
                }
            }
            return _managerRepository.SaveManagerChange(manager);
        }

        public ManagerDTO GetManagerById(int idMngr)
        {
            var manager = _managerRepository.GetManagerByID(idMngr);
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
