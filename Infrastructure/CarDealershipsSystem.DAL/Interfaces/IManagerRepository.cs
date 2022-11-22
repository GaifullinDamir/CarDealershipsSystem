using CarDealershipsSystem.Domain;

namespace CarDealershipsSystem.DAL.Interfaces
{
    public interface IManagerRepository
    {
        IEnumerable<Manager> GetManagers();
    }
}
