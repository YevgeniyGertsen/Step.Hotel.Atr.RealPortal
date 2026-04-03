using System;
using System.Collections.Generic;

namespace Step.Hotel.Atr.Admin.Models;

public partial class TourOffer
{
    public int Id { get; set; }

    public string Heading { get; set; } = null!;

    public string TourImage { get; set; } = null!;

    public string TourImages { get; set; } = null!;

    public string RatingImage { get; set; } = null!;

    public string LocationPng { get; set; } = null!;

    public string CountryName { get; set; } = null!;

    public string CountryNames { get; set; } = null!;

    public string RatingText { get; set; } = null!;

    public string PriceText { get; set; } = null!;
}
