using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class Course
{
    public int Id { get; set; }

    public string? TitleRu { get; set; }

    public string? TitleEn { get; set; }

    public string? DescriptionRu { get; set; }

    public string? DescriptionEn { get; set; }

    public decimal Price { get; set; }

    public string? ImagePath { get; set; }

    public virtual ICollection<CourseEnrollment> CourseEnrollments { get; set; } = new List<CourseEnrollment>();
}
