using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class CartItem2
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int ProductId { get; set; }

    public int Quantity { get; set; }

    public DateTime AddedAt { get; set; }

    public virtual Product3 Product { get; set; } = null!;

    public virtual User5 User { get; set; } = null!;
}
