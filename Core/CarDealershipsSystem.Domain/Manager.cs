using System;
using System.Collections.Generic;

namespace CarDealershipsSystem.Domain;

public partial class Manager
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

    public virtual ICollection<CarOrder> CarOrders { get; } = new List<CarOrder>();

    public virtual Branch IdBranchNavigation { get; set; } = null!;

    public virtual ICollection<ManagerUser> ManagerUsers { get; } = new List<ManagerUser>();
}
