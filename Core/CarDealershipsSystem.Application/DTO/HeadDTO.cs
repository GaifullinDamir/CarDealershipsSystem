namespace CarDealershipsSystem.Application.DTO
{
    public class HeadDTO
    {
        public long HeadPassData { get; set; }

        public string HeadName { get; set; } = null!;

        public string HeadSurname { get; set; } = null!;
        
        public string HeadMiddlename { get; set; } = null!;

        public string HeadPhoneNumber { get; set; } = null!;

        public virtual List<BranchDTO> Branches { get; set; } = new List<BranchDTO>();

        public virtual List<HeadUserDTO> HeadUsers { get; set; } = new List<HeadUserDTO>();
    }
}
