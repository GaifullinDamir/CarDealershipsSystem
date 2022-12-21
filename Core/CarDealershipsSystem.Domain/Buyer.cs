using System;
using System.Collections.Generic;

namespace CarDealershipsSystem.Domain;

public partial class Buyer
{
    public int IdBuyer { get; set; }

    public string BuyerPassData { get; set; } = null!;

    public string BuyerSurname { get; set; } = null!;

    public string BuyerName { get; set; } = null!;

    public string BuyerMiddlename { get; set; } = null!;

    public string BuyerPhoneNumber { get; set; } = null!;

    public virtual ICollection<CarOrder> CarOrders { get; } = new List<CarOrder>();
}
