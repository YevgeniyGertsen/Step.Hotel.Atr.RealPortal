using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class FitnessClass
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? Category { get; set; }

    public string? DayOfWeek { get; set; }

    public TimeOnly? StartTime { get; set; }

    public TimeOnly? EndTime { get; set; }

    public string? TrainerName { get; set; }

    public int MaxParticipants { get; set; }

    public decimal Price { get; set; }

    public bool IsActive { get; set; }
}
