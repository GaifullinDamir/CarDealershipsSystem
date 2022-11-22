using CarDealershipsSystem.Domain;

namespace CarDealershipsSystem.Application.DTO
{
    public class BranchDTO
    {
        public int IdBranch { get; set; }

        public string BranchName { get; set; } = null!;

        public string BranchAddress { get; set; } = null!;

        public string HeadName { get; set; } = null!;

        public string HeadSurname { get; set; } = null!;

        public string HeadMiddlename { get; set; } = null!;

        public long HeadPassData { get; set; }

        public string HeadPhoneNumber { get; set; } = null!;

        public virtual List <CarDTO> Cars { get; set; } = new List<CarDTO>();

        public virtual List <ManagerDTO> Managers { get; set; } = new List<ManagerDTO>();
    }
}
