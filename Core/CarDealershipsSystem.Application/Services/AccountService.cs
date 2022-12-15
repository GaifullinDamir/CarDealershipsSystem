using CarDealershipsSystem.Application.Interfaces;

namespace CarDealershipsSystem.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IHeadUserService _headUserService;
        public AccountService(IHeadUserService headUserService)
        {
            _headUserService = headUserService;
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

        public void RegisterHeadUser( long HeadPassData, string HeadName, string HeadSurname,
           string HeadMiddleName, string HeadPhoneNumber, string HeadLogin,
           string HeadPassword
           )
        {

        }
    }
}
