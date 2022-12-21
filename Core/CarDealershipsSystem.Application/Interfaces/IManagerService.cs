using CarDealershipsSystem.Application.DTO;

namespace CarDealershipsSystem.Application.Interfaces
{
    public interface IManagerService
    {
        IEnumerable<ManagerDTO> GetManagers();

        public bool AddManager(string mngrPassData, string idBranch, string mngrSurname,
            string mngrName, string mngrMiddlename, string mngrPhoneNumber,
            string mngrSalary, string mngrPayDate, string managerPassword,
            string managerLogin);
    }
}
