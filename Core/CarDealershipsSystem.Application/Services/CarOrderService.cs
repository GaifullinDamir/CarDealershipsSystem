using CarDealershipsSystem.Application.DTO;
using CarDealershipsSystem.Application.Interfaces;
using CarDealershipsSystem.DAL.Interfaces;

namespace CarDealershipsSystem.Application.Services
{
    public class CarOrderService : ICarOrderService
    {
        private readonly ICarOrderRepository _carOrderRepository;
        public CarOrderService(ICarOrderRepository carOrderRepository)
        {
            _carOrderRepository = carOrderRepository;
        }

        public IEnumerable<CarOrderDTO> GetCarOrders()
        {
            var carOrders = _carOrderRepository.GetCarOrders();
            var carOrdersDTO = carOrders
                .Select(carorder => new CarOrderDTO
                {
                    IdOrder = carorder.IdOrder,
                    MngrPassData = carorder.MngrPassData,
                    BuyerPassData = carorder.BuyerPassData,
                    ContractDate = carorder.ContractDate,
                    OrderAmount = carorder.OrderAmount
                })
                .ToList();
            return carOrdersDTO;
        }
    }
}
