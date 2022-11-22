using CarDealershipsSystem.Application.DTO;

namespace CarDealershipsSystem.Application.Interfaces
{
    public interface ICarService
    {
        IEnumerable<CarDTO> GetCars();
    }
}
