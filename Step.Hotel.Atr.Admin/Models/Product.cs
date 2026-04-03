using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class Product
{
    public int Id { get; set; }

    public string NameKey { get; set; } = null!;

    public string DescriptionKey { get; set; } = null!;

    public decimal Price { get; set; }

    public string Category { get; set; } = null!;

    public string ImageUrl { get; set; } = null!;
}
