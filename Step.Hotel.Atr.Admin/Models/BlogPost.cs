using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class BlogPost
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string ShortDescription { get; set; } = null!;

    public string Content { get; set; } = null!;

    public string? ImageUrl { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? Author { get; set; }

    public bool IsPublished { get; set; }

    public int ViewCount { get; set; }
}
