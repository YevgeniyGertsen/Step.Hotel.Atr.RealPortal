using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class Event
{
    public int Id { get; set; }

    public DateTime CreateDate { get; set; }

    public string Title { get; set; } = null!;

    public string ImagePath { get; set; } = null!;

    public int TypeImage { get; set; }

    public string Author { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Category { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }
}
