namespace CarDealershipsSystem.Application.DTO
{
    public class CarOrderDTO
    {
        public int IdOrder { get; set; }

        public string VinNumber { get; set; } = null!;

        public string MngrPassData { get; set; } = null!;

        public string BuyerPassData { get; set; } = null!;

        public DateTime ContractDate { get; set; }

        public decimal OrderAmount { get; set; }

        public virtual List<CarDTO> Cars { get; } = new List<CarDTO>();
    }
}
