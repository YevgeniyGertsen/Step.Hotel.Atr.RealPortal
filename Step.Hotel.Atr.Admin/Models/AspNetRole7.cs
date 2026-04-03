using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class AspNetRole7
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? NormalizedName { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public virtual ICollection<AspNetRoleClaim7> AspNetRoleClaim7s { get; set; } = new List<AspNetRoleClaim7>();

    public virtual ICollection<AspNetUser7> Users { get; set; } = new List<AspNetUser7>();
}
