using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class Subscription
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public int DurationDays { get; set; }

    public int ClassesPerWeek { get; set; }

    public bool IncludesPersonalTraining { get; set; }

    public bool IsActive { get; set; }
}
