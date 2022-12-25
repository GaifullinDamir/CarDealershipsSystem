using CarDealershipsSystem.Application.DTO;
using CarDealershipsSystem.Application.Interfaces;
using CarDealershipsSystem.DAL.Interfaces;
using CarDealershipsSystem.Domain;

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
                    IdMngr = carorder.IdMngr,
                    IdBuyer = carorder.IdBuyer,
                    ContractDate = carorder.ContractDate,
                    OrderAmount = carorder.OrderAmount
                })
                .ToList();
            return carOrdersDTO;
        }

        public bool AddCarOrder(string vinNumber, int idMngr,
            int idBuyer, DateTime contractDate,
            decimal orderAmount)
        {
            var carOrder = new CarOrder()
            {
                VinNumber = vinNumber,
                IdMngr = idMngr,
                IdBuyer = idBuyer,
                ContractDate = contractDate,
                OrderAmount = orderAmount
            };
            return _carOrderRepository.SaveCarOrder(carOrder);
        }

        public bool IsExistCarOrderByVinNumber(string vinNumber)
        {
            var carOrders = _carOrderRepository.GetCarOrders();
            foreach (var carOrder in carOrders)
            {
                if (carOrder.VinNumber == vinNumber)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
