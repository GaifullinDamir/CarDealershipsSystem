using CarDealershipsSystem.Domain;

namespace CarDealershipsSystem.DAL.Interfaces
{
    public interface IManagerRepository
    {
        IEnumerable<Manager> GetManagers();

        public bool SaveManager(Manager manager);

        public Manager GetManagerByPassData(string mngrPassData);

        public bool SaveManagerChange(Manager manager);

        public Manager GetManagerByID(int idMngr);
    }
}
