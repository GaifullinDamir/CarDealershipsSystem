using System;
using System.Collections.Generic;

namespace CarDealershipsSystem.Domain;

public partial class CarOrder
{
    public int IdOrder { get; set; }

    public string VinNumber { get; set; } = null!;

    public long MngrPassData { get; set; }

    public long BuyerPassData { get; set; }

    public DateTime ContractDate { get; set; }

    public decimal OrderAmount { get; set; }

    public virtual Buyer BuyerPassDataNavigation { get; set; } = null!;

    public virtual Manager MngrPassDataNavigation { get; set; } = null!;

    public virtual CarExemplar VinNumberNavigation { get; set; } = null!;
}
