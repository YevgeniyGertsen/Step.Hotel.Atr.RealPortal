using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class Service
{
    public int Id { get; set; }

    public string Key { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Language { get; set; } = null!;
}
