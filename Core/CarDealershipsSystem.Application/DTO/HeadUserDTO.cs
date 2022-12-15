namespace CarDealershipsSystem.Application.DTO
{
    public class HeadUserDTO
    {
        public int HeadId { get; set; }

        public string HeadPassword { get; set; } = null!;

        public string HeadLogin { get; set; } = null!;

        public long HeadPassData { get; set; }
    }
}
