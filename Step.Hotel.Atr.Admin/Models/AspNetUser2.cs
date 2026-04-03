using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class AspNetUser2
{
    public string Id { get; set; } = null!;

    public string? UserName { get; set; }

    public string? NormalizedUserName { get; set; }

    public string? Email { get; set; }

    public string? NormalizedEmail { get; set; }

    public bool EmailConfirmed { get; set; }

    public string? PasswordHash { get; set; }

    public string? SecurityStamp { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public string? PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public DateTimeOffset? LockoutEnd { get; set; }

    public bool LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    public virtual ICollection<AspNetUserClaim2> AspNetUserClaim2s { get; set; } = new List<AspNetUserClaim2>();

    public virtual ICollection<AspNetUserLogin2> AspNetUserLogin2s { get; set; } = new List<AspNetUserLogin2>();

    public virtual ICollection<AspNetUserToken2> AspNetUserToken2s { get; set; } = new List<AspNetUserToken2>();

    public virtual ICollection<AspNetRole2> Roles { get; set; } = new List<AspNetRole2>();
}
