namespace CarDealershipsSystem.Application.DTO
{
    public class CarOrderDTO
    {
        public int IdOrder { get; set; }

        public string VinNumber { get; set; } = null!;

        public int IdMngr { get; set; }

        public int IdBuyer { get; set; }

        public DateTime ContractDate { get; set; }

        public decimal OrderAmount { get; set; }

    }
}
