using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class Messag
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Number { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string Message { get; set; } = null!;
}
