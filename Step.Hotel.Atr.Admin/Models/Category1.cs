using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class Category1
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<Product3> Product3s { get; set; } = new List<Product3>();
}
