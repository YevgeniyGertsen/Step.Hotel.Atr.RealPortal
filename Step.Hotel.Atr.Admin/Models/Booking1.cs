using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class Booking1
{
    public int PropertyId { get; set; }

    public DateTime BookingDateTime { get; set; }

    public string ClientName { get; set; } = null!;

    public string? ClientEmail { get; set; }

    public virtual Property Property { get; set; } = null!;
}
