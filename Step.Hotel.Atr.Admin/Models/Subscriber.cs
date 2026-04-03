using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class Subscriber
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public DateTime DateSubscribedUtc { get; set; }
}
