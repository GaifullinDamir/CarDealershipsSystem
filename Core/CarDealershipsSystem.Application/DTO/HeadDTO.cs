namespace CarDealershipsSystem.Application.DTO
{
    public class HeadDTO
    {
        public int IdHead { get; set; }

        public string HeadPassData { get; set; } = null!;

        public string HeadName { get; set; } = null!;

        public string HeadSurname { get; set; } = null!;

        public string HeadMiddlename { get; set; } = null!;

        public string HeadPhoneNumber { get; set; } = null!;

        public string HeadPassword { get; set; } = null!;

        public string HeadLogin { get; set; } = null!;

        public virtual List<BranchDTO> Branches { get; set; } = new List<BranchDTO>();

        
    }
}
