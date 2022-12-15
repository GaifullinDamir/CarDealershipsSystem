using CarDealershipsSystem.Application.DTO;

namespace CarDealershipsSystem.Application.Interfaces
{
    public interface IManagerUserService
    {
        public IEnumerable<ManagerUserDTO> GetManagerUsers();
    }
}
