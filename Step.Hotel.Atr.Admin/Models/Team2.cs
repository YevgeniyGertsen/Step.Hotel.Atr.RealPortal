using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class Team2
{
    public int Id { get; set; }

    public string ImagePath { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Position { get; set; } = null!;

    public string? TwitterUrl { get; set; }

    public string? FacebookUrl { get; set; }

    public string? LinkedInUrl { get; set; }
}
