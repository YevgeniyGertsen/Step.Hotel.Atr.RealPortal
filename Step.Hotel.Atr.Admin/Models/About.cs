using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class About
{
    public int Id { get; set; }

    public string ImagePath { get; set; } = null!;

    public string Period { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool IsInverted { get; set; }
}
