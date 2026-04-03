using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class AspNetRole1
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? NormalizedName { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public virtual ICollection<AspNetRoleClaim1> AspNetRoleClaim1s { get; set; } = new List<AspNetRoleClaim1>();

    public virtual ICollection<AspNetUser1> Users { get; set; } = new List<AspNetUser1>();
}
