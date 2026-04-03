using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class ContactMessage1
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Message { get; set; }

    public DateTime CreatedAt { get; set; }

    public bool IsRead { get; set; }
}
