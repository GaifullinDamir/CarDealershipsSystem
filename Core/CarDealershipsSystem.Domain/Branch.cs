using System;
using System.Collections.Generic;

namespace CarDealershipsSystem.Domain;

public partial class Branch
{
    public int IdBranch { get; set; }

    public string BranchName { get; set; } = null!;

    public string BranchAddress { get; set; } = null!;

    public string HeadPassData { get; set; } = null!;

    public virtual ICollection<Car> Cars { get; } = new List<Car>();

    public virtual Head HeadPassDataNavigation { get; set; } = null!;

    public virtual ICollection<Manager> Managers { get; } = new List<Manager>();
}
