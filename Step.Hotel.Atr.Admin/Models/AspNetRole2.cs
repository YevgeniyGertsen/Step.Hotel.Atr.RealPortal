using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class AspNetRole2
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? NormalizedName { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public virtual ICollection<AspNetRoleClaim2> AspNetRoleClaim2s { get; set; } = new List<AspNetRoleClaim2>();

    public virtual ICollection<AspNetUser2> Users { get; set; } = new List<AspNetUser2>();
}
