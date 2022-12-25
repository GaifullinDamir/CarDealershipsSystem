using CarDealershipsSystem.Application.DTO;

namespace CarDealershipsSystem.Application.Interfaces
{
    public interface IManagerService
    {
        IEnumerable<ManagerDTO> GetManagers();

        public bool AddManager(string mngrPassData, int idBranch, string mngrSurname,
            string mngrName, string mngrMiddlename, string mngrPhoneNumber,
            decimal mngrSalary, DateTime mngrPayDate, string managerPassword,
            string managerLogin);

        public bool IsManagerDataNotUnique(string mngrPassData, string mngrPhoneNumber, string managerLogin, string managerPassword);

        public ManagerDTO GetManagerByPassData(string mngrPassData);

        public bool ManagerChangeData(string option, string mngrPassData, string data, ref string errorMessage);

        public ManagerDTO GetManagerById(int idMngr);



    }
}
