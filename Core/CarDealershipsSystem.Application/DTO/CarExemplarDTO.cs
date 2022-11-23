namespace CarDealershipsSystem.Application.DTO
{
    public class CarExemplarDTO
    {
        public string VinNumber { get; set; } = null!;

        public int IdCar { get; set; }

        public int IdOrder { get; set; }

        public int HorsePower { get; set; }

        public decimal Price { get; set; }

        public string Color { get; set; } = null!;

        public DateTime YearOfAssembly { get; set; }

    }
}
