using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class RClient
{
    public int Id { get; set; }

    public string Clients { get; set; } = null!;

    public string ClientImageUrl { get; set; } = null!;

    public string ClientImageHoverUrl { get; set; } = null!;
}
