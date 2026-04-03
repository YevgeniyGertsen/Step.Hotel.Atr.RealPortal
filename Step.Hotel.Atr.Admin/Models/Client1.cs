using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class Client1
{
    public int Id { get; set; }

    public string ClientUrl { get; set; } = null!;

    public string ClientImageUrl { get; set; } = null!;

    public string ClientImageHoverUrl { get; set; } = null!;
}
