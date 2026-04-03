using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class BannerItem
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Subtitle { get; set; } = null!;

    public string ImagePath { get; set; } = null!;
}
