using CarDealershipsSystem.Application.Interfaces;
using CarDealershipsSystem.DAL.Interfaces;
using CarDealershipsSystem.Domain;

namespace CarDealershipsSystem.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IHeadUserService _headUserService;
        private readonly IBranchRepository _branchRepository;
        private readonly IHeadRepository _headRepository;
        private readonly IHeadUserRepository _headUserRepository;
        public AccountService(IHeadUserService headUserService, IBranchRepository branchRepository, 
            IHeadRepository headRepository, IHeadUserRepository headUserRepository)
        {
            _headUserService = headUserService;
            _branchRepository = branchRepository;
            _headRepository = headRepository;
            _headUserRepository = headUserRepository;
        }

        /*В данном методе, мы получаем из пользовательского ввода логин и пароль, а также получаем логин и паполь из бд.
         Сравниваем их, если они идентичны, возвращаем true. Иначе - false*/
        public bool IsCorrectHeadAuthorizationData(string headLogin, string headPassword)
        {
            var headUsers = _headUserService.GetHeadUsers();
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
            if (_headUserService.GetHeadUsers().Count() != 0) { return true; }
            else
                return false;
        }

        public bool RegisterHeadUser( long headPassData, string headName, string headSurname,
           string headMiddleName, string headPhoneNumber, string headLogin,
           string headPassword
           )
        {
            var headUser = new HeadUser()
            {
                HeadPassData = headPassData,
                HeadLogin = headLogin,
                HeadPassword = headPassword
            };

            var headUsers = new List<HeadUser>();
            headUsers.Add(headUser);

            var branches = _branchRepository.GetBranches().ToList();
            var head = new Head()
            {
                HeadPassData = headPassData,
                HeadName = headName,
                HeadSurname = headSurname,
                HeadMiddlename = headMiddleName,
                HeadPhoneNumber = headPhoneNumber,
                HeadUsers = headUsers,
                Branches = branches
            };
            var result = _headRepository.SaveHead(head);
            if (result)
            { return true; }
            return false;
            
        }
    }
}
