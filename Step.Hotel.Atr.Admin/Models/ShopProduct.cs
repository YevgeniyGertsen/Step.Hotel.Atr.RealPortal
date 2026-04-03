using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class ShopProduct
{
    public int Id { get; set; }

    public string NameProduct { get; set; } = null!;

    public double Price { get; set; }
}
