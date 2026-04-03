using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class User6
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public string Role { get; set; } = null!;

    public bool IsBlocked { get; set; }

    public virtual ICollection<Booking2> Booking2s { get; set; } = new List<Booking2>();

    public virtual ICollection<Review1> Review1s { get; set; } = new List<Review1>();
}
