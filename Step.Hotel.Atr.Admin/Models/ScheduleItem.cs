using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class ScheduleItem
{
    public int Id { get; set; }

    public int FitnessClassId { get; set; }

    public int? TrainerId { get; set; }

    public int DayOfWeek { get; set; }

    public TimeOnly StartTime { get; set; }

    public TimeOnly EndTime { get; set; }

    public int MaxParticipants { get; set; }

    public bool IsActive { get; set; }

    public virtual FitnessClass1 FitnessClass { get; set; } = null!;

    public virtual Trainer? Trainer { get; set; }
}
