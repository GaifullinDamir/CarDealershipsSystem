﻿using CarDealershipsSystem.Application.DTO;
using CarDealershipsSystem.Application.Interfaces;
using CarDealershipsSystem.DAL.Interfaces;

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
    }
}
