using CarDealershipsSystem.Application.DTO;

namespace CarDealershipsSystem.Application.Interfaces
{
    public interface IManagerService
    {
        IEnumerable<ManagerDTO> GetManagers();
    }
}
