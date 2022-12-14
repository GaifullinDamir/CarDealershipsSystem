using System;
using System.Collections.Generic;

namespace CarDealershipsSystem.Domain;

public partial class Car
{
    public int IdCar { get; set; }

    public int IdBranch { get; set; }

    public string Brand { get; set; } = null!;

    public string Model { get; set; } = null!;

    public string BodyType { get; set; } = null!;

    public virtual ICollection<CarExemplar> CarExemplars { get; set; } = new List<CarExemplar>();

    public virtual Branch IdBranchNavigation { get; set; } = null!;
}
