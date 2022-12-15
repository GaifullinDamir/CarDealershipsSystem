using System;
using System.Collections.Generic;

namespace CarDealershipsSystem.Domain;

public partial class HeadUser
{
    public int HeadId { get; set; }

    public string HeadPassword { get; set; } = null!;

    public string HeadLogin { get; set; } = null!;

    public long HeadPassData { get; set; }

    public virtual Head HeadPassDataNavigation { get; set; } = null!;
}
