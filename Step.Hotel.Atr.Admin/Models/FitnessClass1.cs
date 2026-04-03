using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class FitnessClass1
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int DurationMinutes { get; set; }

    public decimal? Price { get; set; }

    public string? ImageUrl { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<ScheduleItem> ScheduleItems { get; set; } = new List<ScheduleItem>();
}
