using CarDealershipsSystem.Domain;

namespace CarDealershipsSystem.DAL.Interfaces
{
    public interface IManagerUserRepository
    {
        public IEnumerable<ManagerUser> GetManagerUsers();
    }
}
