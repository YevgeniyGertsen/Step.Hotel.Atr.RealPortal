using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class Account
{
    public int Id { get; set; }

    public int ClientId { get; set; }

    public string AccountNo { get; set; } = null!;

    public decimal Balance { get; set; }

    public string Currency { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime OpenedAt { get; set; }

    public virtual Client Client { get; set; } = null!;
}
