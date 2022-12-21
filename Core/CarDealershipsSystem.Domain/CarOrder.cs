using System;
using System.Collections.Generic;

namespace CarDealershipsSystem.Domain;

public partial class CarOrder
{
    public int IdOrder { get; set; }

    public string VinNumber { get; set; } = null!;

    public int IdMngr { get; set; }

    public int IdBuyer { get; set; }

    public DateTime ContractDate { get; set; }

    public decimal OrderAmount { get; set; }

    public virtual Buyer IdBuyerNavigation { get; set; } = null!;

    public virtual Manager IdMngrNavigation { get; set; } = null!;

    public virtual CarExemplar VinNumberNavigation { get; set; } = null!;
}
