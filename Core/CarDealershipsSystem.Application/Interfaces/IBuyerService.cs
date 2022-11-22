﻿using CarDealershipsSystem.Application.DTO;

namespace CarDealershipsSystem.Application.Interfaces
{
    public interface IBuyerService
    {
        IEnumerable<BuyerDTO> GetBuyers();
    }
}