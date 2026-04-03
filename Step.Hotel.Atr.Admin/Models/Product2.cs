using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class Product2
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public string? Description { get; set; }

    public string? ImageUrl { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<CartItem1> CartItem1s { get; set; } = new List<CartItem1>();

    public virtual ICollection<Order1> Order1s { get; set; } = new List<Order1>();
}
