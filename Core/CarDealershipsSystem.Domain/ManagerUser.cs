using System;
using System.Collections.Generic;

namespace CarDealershipsSystem.Domain;

public partial class ManagerUser
{
    public int ManagerId { get; set; }

    public string ManagerPassword { get; set; } = null!;

    public string ManagerLogin { get; set; } = null!;

    public long MngrPassData { get; set; }

    public virtual Manager MngrPassDataNavigation { get; set; } = null!;
}
