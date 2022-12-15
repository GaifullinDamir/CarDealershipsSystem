using CarDealershipsSystem.Application.DTO;

namespace CarDealershipsSystem.Application.Interfaces
{
    public interface IHeadService
    {
        IEnumerable<HeadDTO> GetHeads();
    }
}
