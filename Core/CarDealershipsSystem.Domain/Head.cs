using System;
using System.Collections.Generic;

namespace CarDealershipsSystem.Domain;

public partial class Head
{
    public long HeadPassData { get; set; }

    public string HeadName { get; set; } = null!;

    public string HeadSurname { get; set; } = null!;

    public string HeadMiddlename { get; set; } = null!;

    public string HeadPhoneNumber { get; set; } = null!;

    //set добавил сам!
    public virtual ICollection<Branch> Branches { get; set; } = new List<Branch>();
    //set добавил сам!
    public virtual ICollection<HeadUser> HeadUsers { get; set; } = new List<HeadUser>();
}
