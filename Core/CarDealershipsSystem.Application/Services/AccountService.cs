using CarDealershipsSystem.Application.Interfaces;
using CarDealershipsSystem.DAL.Interfaces;
using CarDealershipsSystem.Domain;

namespace CarDealershipsSystem.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IBranchRepository _branchRepository;
        private readonly IHeadRepository _headRepository;
        private readonly IHeadService _headService;
        public AccountService(IBranchRepository branchRepository, 
            IHeadRepository headRepository,
            IHeadService headService)
        {
            _branchRepository = branchRepository;
            _headRepository = headRepository;
            _headService = headService;
        }

        /*В данном методе, мы получаем из пользовательского ввода логин и пароль, а также получаем логин и паполь из бд.
         Сравниваем их, если они идентичны, возвращаем true. Иначе - false*/
        public bool IsCorrectHeadAuthorizationData(string headLogin, string headPassword)
        {
            var headUsers = _headService.GetHeads();
            foreach (var headUser in headUsers)
            {
                if(headLogin == headUser.HeadLogin && headPassword == headUser.HeadPassword)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsHeadAccountExist()
        {
            if (_headService.GetHeads().Count() != 0) { return true; }
            else
                return false;
        }

        public bool RegisterHeadUser( string headPassData, string headName, string headSurname,
           string headMiddleName, string headPhoneNumber, string headLogin,
           string headPassword
           )
        {
            var branches = _branchRepository.GetBranches().ToList();
            var head = new Head()
            {
                HeadPassData = headPassData,
                HeadName = headName,
                HeadSurname = headSurname,
                HeadMiddlename = headMiddleName,
                HeadPhoneNumber = headPhoneNumber,
                HeadLogin = headLogin,
                HeadPassword = headPassword,
                Branches = branches
            };
            if (_headRepository.SaveHead(head))
            { return true; }
            return false;
            
        }

        public bool HeadChangeData(string option, string data)
        {
            var head = _headRepository.GetHeads().FirstOrDefault();

            if (option == "Имя")
            {
                if (data.Length > 30)
                {
                    return false;
                }
                head.HeadName = data;
            }    
            else if(option == "Фамилия")
            {
                if (data.Length > 30)
                {
                    return false;
                }
                head.HeadSurname = data;
            }
            else if(option == "Отчество")
            {
                if (data.Length > 30)
                {
                    return false;
                }
                head.HeadMiddlename = data;
            }
            else if (option == "Паспортные данные")
            {
                if (data.Length > 20)
                {
                    return false;
                }
                head.HeadPassData = data;
            }
            else if (option == "Номер телефона")
            {
                if (data.Length > 20)
                {
                    return false;
                }
                head.HeadPhoneNumber = data;
            }
            else if (option == "Логин")
            {
                if (data.Length > 20)
                {
                    return false;
                }
                head.HeadLogin = data;
            }
            else if (option == "Пароль")
            {
                if (data.Length > 20)
                {
                    return false;
                }
                head.HeadPassword = data;
            }
            return _headRepository.SaveHeadChange(head);
        }
    }
}
