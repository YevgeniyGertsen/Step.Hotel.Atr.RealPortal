using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class OrderItem
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public int Quantity { get; set; }

    public decimal Price { get; set; }

    public virtual Order2 Order { get; set; } = null!;

    public virtual Product3 Product { get; set; } = null!;
}
