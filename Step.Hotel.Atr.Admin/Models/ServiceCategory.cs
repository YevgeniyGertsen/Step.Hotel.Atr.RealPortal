using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class ServiceCategory
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public virtual ICollection<Service3> Service3s { get; set; } = new List<Service3>();
}
