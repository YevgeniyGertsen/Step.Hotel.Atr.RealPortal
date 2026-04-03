using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class Wallet
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public decimal Balance { get; set; }
}
