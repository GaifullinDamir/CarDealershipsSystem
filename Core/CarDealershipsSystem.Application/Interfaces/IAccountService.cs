namespace CarDealershipsSystem.Application.Interfaces
{
    public interface IAccountService
    {
        public bool IsCorrectHeadAuthorizationData(string login, string password);

        public bool IsHeadAccountExist();

        public void RegisterHeadUser(
            long HeadPassData, string HeadName, string HeadSurname,
            string HeadMiddleName, string HeadPhoneNumber, string HeadLogin,
            string HeadPassword
            );
    }
}
