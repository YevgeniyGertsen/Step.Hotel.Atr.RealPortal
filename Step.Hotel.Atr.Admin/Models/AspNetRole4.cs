using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class AspNetRole4
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? NormalizedName { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public virtual ICollection<AspNetRoleClaim4> AspNetRoleClaim4s { get; set; } = new List<AspNetRoleClaim4>();

    public virtual ICollection<AspNetUser4> Users { get; set; } = new List<AspNetUser4>();
}
