using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class AspNetUser4
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

    public virtual ICollection<AspNetUserClaim4> AspNetUserClaim4s { get; set; } = new List<AspNetUserClaim4>();

    public virtual ICollection<AspNetUserLogin4> AspNetUserLogin4s { get; set; } = new List<AspNetUserLogin4>();

    public virtual ICollection<AspNetUserToken4> AspNetUserToken4s { get; set; } = new List<AspNetUserToken4>();

    public virtual ICollection<AspNetRole4> Roles { get; set; } = new List<AspNetRole4>();
}
