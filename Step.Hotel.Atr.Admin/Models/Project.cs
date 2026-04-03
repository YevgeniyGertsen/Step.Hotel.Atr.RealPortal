using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class Project
{
    public int Id { get; set; }

    public string NameKey { get; set; } = null!;

    public string LocationKey { get; set; } = null!;

    public string TypeKey { get; set; } = null!;

    public string YearKey { get; set; } = null!;

    public string StatusKey { get; set; } = null!;

    public string StyleKey { get; set; } = null!;

    public string Image { get; set; } = null!;

    public string DescriptionKey { get; set; } = null!;
}
