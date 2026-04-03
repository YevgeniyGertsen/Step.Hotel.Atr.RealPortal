using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class AspNetRole5
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? NormalizedName { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public virtual ICollection<AspNetRoleClaim5> AspNetRoleClaim5s { get; set; } = new List<AspNetRoleClaim5>();

    public virtual ICollection<AspNetUser5> Users { get; set; } = new List<AspNetUser5>();
}
