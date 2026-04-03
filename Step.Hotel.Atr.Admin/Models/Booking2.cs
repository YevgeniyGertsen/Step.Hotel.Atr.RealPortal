using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class Booking2
{
    public int Id { get; set; }

    public DateTime CheckInDate { get; set; }

    public DateTime CheckOutDate { get; set; }

    public int RoomId { get; set; }

    public int UserId { get; set; }

    public decimal TotalPrice { get; set; }

    public string Status { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public string RoomName { get; set; } = null!;

    public virtual Room1 Room { get; set; } = null!;

    public virtual User6 User { get; set; } = null!;
}
