using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int CustomerId { get; set; }

    public DateTime? OrderDate { get; set; }

    public decimal Amount { get; set; }
}
