using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class ContactSubmission
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Message { get; set; }

    public DateTime SubmittedAt { get; set; }

    public string? IpAddress { get; set; }
}
