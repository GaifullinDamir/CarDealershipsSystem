namespace CarDealershipsSystem.Application.Interfaces
{
    public interface IAccountService
    {
        public bool IsCorrectHeadAuthorizationData(string login, string password);

        public bool IsHeadAccountExist();

        public bool RegisterHeadUser( long headPassData, string headName, string headSurname,
            string headMiddleName, string headPhoneNumber, string headLogin,
            string headPassword
            );
    }
}
