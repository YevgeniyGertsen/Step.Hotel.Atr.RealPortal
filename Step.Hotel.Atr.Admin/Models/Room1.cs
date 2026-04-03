using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class Room1
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public int Capacity { get; set; }

    public bool IsAvailable { get; set; }

    public string Description { get; set; } = null!;

    public string ImageUrl { get; set; } = null!;

    public int MaxOccupancy { get; set; }

    public virtual ICollection<Booking2> Booking2s { get; set; } = new List<Booking2>();

    public virtual ICollection<Review1> Review1s { get; set; } = new List<Review1>();
}
