using CarDealershipsSystem.Application.DTO;

namespace CarDealershipsSystem.Application.Interfaces
{
    public interface ICarOrderService
    {
        IEnumerable<CarOrderDTO> GetCarOrders();
    }
}
