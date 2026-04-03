using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class Student
{
    public int Id { get; set; }

    public DateTime CreateDate { get; set; }

    public string Name { get; set; } = null!;

    public string Department { get; set; } = null!;

    public int Course { get; set; }
}
