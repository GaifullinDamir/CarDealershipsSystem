using CarDealershipsSystem.Application.DTO;

namespace CarDealershipsSystem.Application.Interfaces
{
    public interface IHeadUserService
    {
        public IEnumerable<HeadUserDTO> GetHeadUsers();
    }
}
