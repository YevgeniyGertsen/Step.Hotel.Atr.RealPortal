using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class Booking
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Service { get; set; } = null!;

    public DateTime Date { get; set; }

    public string Phone { get; set; } = null!;
}
