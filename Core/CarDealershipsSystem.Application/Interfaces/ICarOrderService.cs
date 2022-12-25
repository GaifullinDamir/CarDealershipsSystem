using CarDealershipsSystem.Application.DTO;

namespace CarDealershipsSystem.Application.Interfaces
{
    public interface ICarOrderService
    {
        IEnumerable<CarOrderDTO> GetCarOrders();

        public bool AddCarOrder(string vinNumber, int idMngr,
            int idBuyer, DateTime contractDate,
            decimal orderAmount);

        public bool IsExistCarOrderByVinNumber(string vinNumber);

        public bool DeleteCarOrder(int idCarOrder);
    }
}
