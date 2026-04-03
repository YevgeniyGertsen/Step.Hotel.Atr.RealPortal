using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class Property
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Location { get; set; } = null!;

    public decimal Price { get; set; }

    public int Bedrooms { get; set; }

    public int Bathrooms { get; set; }

    public int Area { get; set; }

    public int ParkingSpots { get; set; }

    public virtual ICollection<Booking1> Booking1s { get; set; } = new List<Booking1>();
}
