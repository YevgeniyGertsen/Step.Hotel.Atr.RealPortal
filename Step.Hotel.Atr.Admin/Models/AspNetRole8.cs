using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class AspNetRole8
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? NormalizedName { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public virtual ICollection<AspNetRoleClaim8> AspNetRoleClaim8s { get; set; } = new List<AspNetRoleClaim8>();

    public virtual ICollection<AspNetUser8> Users { get; set; } = new List<AspNetUser8>();
}
