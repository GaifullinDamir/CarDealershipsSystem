using CarDealershipsSystem.Domain;

namespace CarDealershipsSystem.DAL.Interfaces
{
    public interface ICarOrderRepository
    {
        IEnumerable<CarOrder> GetCarOrders();
    }
}
