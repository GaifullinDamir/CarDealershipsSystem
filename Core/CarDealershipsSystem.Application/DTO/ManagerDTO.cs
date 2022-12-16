namespace CarDealershipsSystem.Application.DTO
{
    public class ManagerDTO
    {
        public int IdMngr { get; set; }

        public string MngrPassData { get; set; } = null!;

        public int IdBranch { get; set; }

        public string MngrSurname { get; set; } = null!;

        public string MngrName { get; set; } = null!;

        public string MngrMiddlename { get; set; } = null!;

        public string MngrPhoneNumber { get; set; } = null!;

        public decimal MngrSalary { get; set; }

        public DateTime MngrPayDate { get; set; }

        public decimal? MngrPrize { get; set; }

        public string ManagerPassword { get; set; } = null!;

        public string ManagerLogin { get; set; } = null!;

        public virtual List<CarOrderDTO> CarOrders { get; set; } = new List<CarOrderDTO>();
    }
}
