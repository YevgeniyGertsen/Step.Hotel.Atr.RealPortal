using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class Order1
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public int ProductId { get; set; }

    public DateTime StartDate { get; set; }

    public int FormatId { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Product2 Product { get; set; } = null!;
}
