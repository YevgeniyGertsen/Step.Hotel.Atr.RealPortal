using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class Service3
{
    public int Id { get; set; }

    public int? ServiceCategoryId { get; set; }

    public string? DescriptionShort { get; set; }

    public string? Description { get; set; }

    public string? Photo { get; set; }

    public int Type { get; set; }

    public string Title { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public virtual ServiceCategory? ServiceCategory { get; set; }
}
