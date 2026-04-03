using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class Portfolio
{
    public int Id { get; set; }

    public string ImagePath { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Client { get; set; } = null!;
}
