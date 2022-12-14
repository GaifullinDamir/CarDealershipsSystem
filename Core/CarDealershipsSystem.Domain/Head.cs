using System;
using System.Collections.Generic;

namespace CarDealershipsSystem.Domain;

public partial class Head
{
    public int IdHead { get; set; }

    public string HeadPassData { get; set; } = null!;

    public string HeadName { get; set; } = null!;

    public string HeadSurname { get; set; } = null!;

    public string HeadMiddlename { get; set; } = null!;

    public string HeadPhoneNumber { get; set; } = null!;

    public string HeadPassword { get; set; } = null!;

    public string HeadLogin { get; set; } = null!;

    public virtual ICollection<Branch> Branches { get; set; } = new List<Branch>();
}
