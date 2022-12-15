namespace CarDealershipsSystem.Application.Interfaces
{
    public interface IAccountService
    {
        public bool IsCorrectHeadAuthorizationData(string login, string password);
    }
}
