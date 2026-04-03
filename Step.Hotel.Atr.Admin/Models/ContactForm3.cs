using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class ContactForm3
{
    public int Id { get; set; }

    public DateTime CreateDate { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string Messege { get; set; } = null!;
}
