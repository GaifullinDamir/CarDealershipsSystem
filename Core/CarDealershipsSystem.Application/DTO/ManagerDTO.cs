namespace CarDealershipsSystem.Application.DTO
{
    public class ManagerDTO
    {
        public long MngrPassData { get; set; }

        public int IdBranch { get; set; }

        public string MngrSurname { get; set; } = null!;

        public string MngrName { get; set; } = null!;

        public string MngrMiddlename { get; set; } = null!;

        public string MngrPhoneNumber { get; set; } = null!;

        public decimal MngrSalary { get; set; }

        public DateTime MngrPayDate { get; set; }

        public decimal? MngrPrize { get; set; }

        public virtual List<CarOrderDTO> CarOrders { get; set; } = new List<CarOrderDTO>();
    }
}
