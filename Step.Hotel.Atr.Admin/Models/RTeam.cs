using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class RTeam
{
    public int Id { get; set; }

    public string PictureUrl { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string Position { get; set; } = null!;

    public string Desctiption { get; set; } = null!;
}
