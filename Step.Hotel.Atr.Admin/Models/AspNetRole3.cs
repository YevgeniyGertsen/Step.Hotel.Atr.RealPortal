using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class AspNetRole3
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? NormalizedName { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public virtual ICollection<AspNetRoleClaim3> AspNetRoleClaim3s { get; set; } = new List<AspNetRoleClaim3>();

    public virtual ICollection<AspNetUser3> Users { get; set; } = new List<AspNetUser3>();
}
