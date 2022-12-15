namespace CarDealershipsSystem.Application.DTO
{
    public class ManagerUserDTO
    {
        public int ManagerId { get; set; }

        public string ManagerPassword { get; set; } = null!;

        public string ManagerLogin { get; set; } = null!;

        public long MngrPassData { get; set; }
    }
}
