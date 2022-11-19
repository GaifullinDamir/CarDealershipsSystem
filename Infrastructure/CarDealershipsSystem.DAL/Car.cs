using System;
using System.Collections.Generic;

namespace CarDealershipsSystem.DAL;

public partial class Car
{
    public int IdCar { get; set; }

    public int IdBranch { get; set; }

    public int IdOrder { get; set; }

    public string Brand { get; set; } = null!;

    public string Model { get; set; } = null!;

    public string BodyType { get; set; } = null!;

    public int Quantity { get; set; }

    public virtual ICollection<CarExemplar> CarExemplars { get; } = new List<CarExemplar>();

    public virtual Branch IdBranchNavigation { get; set; } = null!;

    public virtual CarOrder IdOrderNavigation { get; set; } = null!;
}
