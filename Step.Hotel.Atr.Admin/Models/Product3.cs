using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class Product3
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal Price { get; set; }

    public decimal? OldPrice { get; set; }

    public string ImageUrl { get; set; } = null!;

    public double Rating { get; set; }

    public int StockQuantity { get; set; }

    public bool IsOnSale { get; set; }

    public int CategoryId { get; set; }

    public virtual ICollection<CartItem2> CartItem2s { get; set; } = new List<CartItem2>();

    public virtual Category1 Category { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
