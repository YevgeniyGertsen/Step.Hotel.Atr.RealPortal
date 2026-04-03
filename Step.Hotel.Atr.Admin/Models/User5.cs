using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class User5
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string? Address { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<CartItem2> CartItem2s { get; set; } = new List<CartItem2>();

    public virtual ICollection<Order2> Order2s { get; set; } = new List<Order2>();
}
