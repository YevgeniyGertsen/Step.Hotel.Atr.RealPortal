using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class AspNetUser5
{
    public string Id { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

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

    public virtual ICollection<AspNetUserClaim5> AspNetUserClaim5s { get; set; } = new List<AspNetUserClaim5>();

    public virtual ICollection<AspNetUserLogin5> AspNetUserLogin5s { get; set; } = new List<AspNetUserLogin5>();

    public virtual ICollection<AspNetUserToken5> AspNetUserToken5s { get; set; } = new List<AspNetUserToken5>();

    public virtual ICollection<AspNetRole5> Roles { get; set; } = new List<AspNetRole5>();
}
