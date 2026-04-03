using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class RRoom
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Capacity { get; set; }

    public decimal Price { get; set; }

    public string Description { get; set; } = null!;

    public string Facilities { get; set; } = null!;
}
