using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class User2
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Role { get; set; }
}
