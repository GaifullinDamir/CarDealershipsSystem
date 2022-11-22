﻿using CarDealershipsSystem.Domain;

namespace CarDealershipsSystem.Application.DTO
{
    public class BuyerDTO
    {
        public long BuyerPassData { get; set; }

        public string BuyerSurname { get; set; } = null!;

        public string BuyerName { get; set; } = null!;

        public string BuyerMiddlename { get; set; } = null!;

        public string BuyerPhoneNumber { get; set; } = null!;

        public virtual List<CarOrderDTO> CarOrders { get; set; } = new List<CarOrderDTO>();
    }
}
