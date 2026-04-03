using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class User3
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Role { get; set; } = null!;
}
