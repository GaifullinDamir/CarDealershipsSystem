using CarDealershipsSystem.Application.DTO;

namespace CarDealershipsSystem.Application.Interfaces
{
    public interface ICarExemplarService
    {
        IEnumerable<CarExemplarDTO> GetCarExemplars();
    }
}
