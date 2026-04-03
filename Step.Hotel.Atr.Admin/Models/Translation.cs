using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class Translation
{
    public int Id { get; set; }

    public string Key { get; set; } = null!;

    public string Culture { get; set; } = null!;

    public string Value { get; set; } = null!;

    public string? Scope { get; set; }

    public DateTime UpdatedAt { get; set; }
}
