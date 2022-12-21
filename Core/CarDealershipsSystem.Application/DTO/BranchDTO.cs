using CarDealershipsSystem.Domain;

namespace CarDealershipsSystem.Application.DTO
{
    public class BranchDTO
    {
        public int IdBranch { get; set; }

        public string BranchName { get; set; } = null!;

        public string BranchAddress { get; set; } = null!;

        public int IdHead { get; set; }

        public virtual List <CarDTO> Cars { get; set; } = new List<CarDTO>();

        public virtual List <ManagerDTO> Managers { get; set; } = new List<ManagerDTO>();
    }
}
