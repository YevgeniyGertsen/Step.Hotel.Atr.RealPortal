using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class CartItem
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public string? SessionId { get; set; }

    public int ProductId { get; set; }

    public int Quantity { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Product1 Product { get; set; } = null!;
}
