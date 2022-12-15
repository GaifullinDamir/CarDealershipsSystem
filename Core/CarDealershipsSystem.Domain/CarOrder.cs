using System;
using System.Collections.Generic;

namespace CarDealershipsSystem.DAL;

public partial class CarOrder
{
    public int IdOrder { get; set; }

    public string VinNumber { get; set; } = null!;

    public string MngrPassData { get; set; } = null!;

    public string BuyerPassData { get; set; } = null!;

    public DateTime ContractDate { get; set; }

    public decimal OrderAmount { get; set; }

    public virtual Buyer BuyerPassDataNavigation { get; set; } = null!;

    public virtual Manager MngrPassDataNavigation { get; set; } = null!;

    public virtual CarExemplar VinNumberNavigation { get; set; } = null!;
}
