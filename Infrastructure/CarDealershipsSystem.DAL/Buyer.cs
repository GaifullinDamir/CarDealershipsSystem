using System;
using System.Collections.Generic;

namespace CarDealershipsSystem.DAL;

public partial class Buyer
{
    public long BuyerPassData { get; set; }

    public string BuyerSurname { get; set; } = null!;

    public string BuyerName { get; set; } = null!;

    public string BuyerMiddlename { get; set; } = null!;

    public string BuyerPhoneNumber { get; set; } = null!;

    public virtual ICollection<CarOrder> CarOrders { get; } = new List<CarOrder>();
}
