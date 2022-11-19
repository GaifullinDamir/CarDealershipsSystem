using System;
using System.Collections.Generic;

namespace CarDealershipsSystem.DAL.Repositories;

public partial class Branch
{
    public int IdBranch { get; set; }

    public string BranchName { get; set; } = null!;

    public string BranchAddress { get; set; } = null!;

    public string HeadName { get; set; } = null!;

    public string HeadSurname { get; set; } = null!;

    public string HeadMiddlename { get; set; } = null!;

    public long HeadPassData { get; set; }

    public string HeadPhoneNumber { get; set; } = null!;

    public virtual ICollection<Car> Cars { get; } = new List<Car>();

    public virtual ICollection<Manager> Managers { get; } = new List<Manager>();
}
