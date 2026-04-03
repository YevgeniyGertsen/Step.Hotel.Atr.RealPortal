using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class Service2
{
    public int Id { get; set; }

    public DateTime CreateDate { get; set; }

    public string Title { get; set; } = null!;

    public string Slug { get; set; } = null!;

    public string ShortDescription { get; set; } = null!;

    public string FullDescription { get; set; } = null!;

    public string IconClass { get; set; } = null!;
}
