using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class CartItem1
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public string Username { get; set; } = null!;

    public int Quantity { get; set; }

    public virtual Product2 Product { get; set; } = null!;
}
