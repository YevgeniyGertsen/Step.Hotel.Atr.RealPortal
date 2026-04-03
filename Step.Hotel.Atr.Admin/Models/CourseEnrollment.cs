using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class CourseEnrollment
{
    public string UserId { get; set; } = null!;

    public int CourseId { get; set; }

    public DateTime EnrolledAt { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual AspNetUser1 User { get; set; } = null!;
}
