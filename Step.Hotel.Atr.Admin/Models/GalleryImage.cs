using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class GalleryImage
{
    public int Id { get; set; }

    public string ImageUrl { get; set; } = null!;

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? Category { get; set; }

    public DateTime UploadedAt { get; set; }

    public int DisplayOrder { get; set; }

    public bool IsVisible { get; set; }
}
