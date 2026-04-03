using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class UserInfo
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string ConfirmPassword { get; set; } = null!;

    public int? Age { get; set; }

    public bool IsAgree { get; set; }
}
