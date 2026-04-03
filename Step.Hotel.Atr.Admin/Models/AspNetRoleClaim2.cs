using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class AspNetRoleClaim2
{
    public int Id { get; set; }

    public string RoleId { get; set; } = null!;

    public string? ClaimType { get; set; }

    public string? ClaimValue { get; set; }

    public virtual AspNetRole2 Role { get; set; } = null!;
}
