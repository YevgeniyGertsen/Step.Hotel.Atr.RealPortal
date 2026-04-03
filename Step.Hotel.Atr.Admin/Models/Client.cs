using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class Client
{
    public int Id { get; set; }

    public string Iin { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string? Phone { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
}
