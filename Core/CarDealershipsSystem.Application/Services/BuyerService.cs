using CarDealershipsSystem.Application.DTO;
using CarDealershipsSystem.Application.Interfaces;
using CarDealershipsSystem.DAL.Interfaces;
using CarDealershipsSystem.Domain;

namespace CarDealershipsSystem.Application.Services
{
    public class BuyerService : IBuyerService
    {
        private readonly IBuyerRepository _buyerRepository;
        public BuyerService(IBuyerRepository buyerRepository)
        {
            _buyerRepository = buyerRepository;
        }

        public IEnumerable<BuyerDTO> GetBuyers()
        {
            var buyers = _buyerRepository
                .GetBuyers();
            var buyersDTO = buyers
                .Select(buyer => new BuyerDTO
            {
                BuyerPassData = buyer.BuyerPassData,
                BuyerSurname = buyer.BuyerSurname,
                BuyerName = buyer.BuyerName,
                BuyerMiddlename = buyer.BuyerMiddlename,
                BuyerPhoneNumber = buyer.BuyerPhoneNumber,
                CarOrders = buyer.CarOrders.Select(carorder => new CarOrderDTO
                {
                    IdOrder = carorder.IdOrder,
                    IdMngr = carorder.IdMngr,
                    IdBuyer = carorder.IdBuyer,
                    ContractDate = carorder.ContractDate,
                    OrderAmount = carorder.OrderAmount
                })
                .ToList()
            });
            return buyersDTO;
        }

        public BuyerDTO GetBuyerById(int idBuyer)
        {
            var buyer = _buyerRepository.GetBuyerById(idBuyer);
            var buyerDTO = new BuyerDTO()
            {
                BuyerPassData = buyer.BuyerPassData,
                BuyerSurname = buyer.BuyerSurname,
                BuyerName = buyer.BuyerName,
                BuyerMiddlename = buyer.BuyerMiddlename,
                BuyerPhoneNumber = buyer.BuyerPhoneNumber,
                CarOrders = buyer.CarOrders.Select(carorder => new CarOrderDTO
                {
                    IdOrder = carorder.IdOrder,
                    IdMngr = carorder.IdMngr,
                    IdBuyer = carorder.IdBuyer,
                    ContractDate = carorder.ContractDate,
                    OrderAmount = carorder.OrderAmount
                })
                .ToList()
            };
            return buyerDTO;
        }

        public bool IsBuyerExistByPassData(string buyerPassData)
        {
            if (_buyerRepository.GetBuyerByPassData(buyerPassData) == null)
            {
                return false;
            }
            return true;
        }

        public bool AddBuyer(string buyerPassData, string buyerSurname,
            string buyerName, string buyerMiddlename,
            string buyerPhoneNumber)
        {
            var buyer = new Buyer()
            {
                BuyerPassData = buyerPassData,
                BuyerSurname = buyerSurname,
                BuyerName = buyerName,
                BuyerMiddlename = buyerMiddlename,
                BuyerPhoneNumber = buyerPhoneNumber
            };
            return _buyerRepository.SaveBuyer(buyer);
        }
    }
}
