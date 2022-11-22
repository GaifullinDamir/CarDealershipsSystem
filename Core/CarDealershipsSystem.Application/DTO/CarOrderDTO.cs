namespace CarDealershipsSystem.Application.DTO
{
    public class CarOrderDTO
    {
        public int IdOrder { get; set; }

        public long MngrPassData { get; set; }

        public long BuyerPassData { get; set; }

        public DateTime ContractDate { get; set; }

        public decimal OrderAmount { get; set; }

        public virtual List<CarDTO> Cars { get; } = new List<CarDTO>();
    }
}
