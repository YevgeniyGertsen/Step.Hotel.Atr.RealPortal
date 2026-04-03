using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class AspNetRole6
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? NormalizedName { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public virtual ICollection<AspNetRoleClaim6> AspNetRoleClaim6s { get; set; } = new List<AspNetRoleClaim6>();

    public virtual ICollection<AspNetUser6> Users { get; set; } = new List<AspNetUser6>();
}
