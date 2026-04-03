using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class ServicesDbfirst
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string ShortDesc { get; set; } = null!;

    public string FullDesc { get; set; } = null!;

    public string IconClass { get; set; } = null!;

    public DateTime CreateDate { get; set; }
}
