using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class Review1
{
    public int Id { get; set; }

    public string Text { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public bool IsApproved { get; set; }

    public int UserId { get; set; }

    public int Rating { get; set; }

    public int RoomId { get; set; }

    public virtual Room1 Room { get; set; } = null!;

    public virtual User6 User { get; set; } = null!;
}
