using CarDealershipsSystem.Domain;

namespace CarDealershipsSystem.DAL.Interfaces
{
    public interface ICarOrderRepository
    {
        IEnumerable<CarOrder> GetCarOrders();

        public bool SaveCarOrder(CarOrder carOrder);

        public CarOrder GetCarOrderById(int idCarOrder);

        public bool DeleteCarOrder(CarOrder carOrder);
    }
}
