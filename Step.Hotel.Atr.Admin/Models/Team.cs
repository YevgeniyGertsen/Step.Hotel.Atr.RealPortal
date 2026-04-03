using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class Team
{
    public int Id { get; set; }

    public DateTime CreateDate { get; set; }

    public string PictureUrl { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string Position { get; set; } = null!;

    public string Desctiption { get; set; } = null!;
}
