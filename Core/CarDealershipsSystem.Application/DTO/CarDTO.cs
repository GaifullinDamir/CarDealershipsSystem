namespace CarDealershipsSystem.Application.DTO
{
    public class CarDTO
    {
        public int IdCar { get; set; }

        public int IdBranch { get; set; }

        public int IdOrder { get; set; }

        public string Brand { get; set; } = null!;

        public string Model { get; set; } = null!;

        public string BodyType { get; set; } = null!;

        public int Quantity { get; set; }

        public virtual List<CarExemplarDTO> CarExemplars { get; set; } = new List<CarExemplarDTO>();
    }
}
