using System;
using System.Collections.Generic;

namespace CarDealershipsSystem.Domain;

public partial class CarExemplar
{
    public string VinNumber { get; set; } = null!;

    public int IdCar { get; set; }

    public int IdOrder { get; set; }

    public int HorsePower { get; set; }

    public decimal Price { get; set; }

    public string Color { get; set; } = null!;

    public DateTime YearOfAssembly { get; set; }

    //Свойство навигации
    public virtual Car IdCarNavigation { get; set; } = null!;

    //Свойство навигации
    public virtual CarOrder IdOrderNavigation { get; set; } = null!;
}
