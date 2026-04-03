namespace Step.Hotel.Atr.RealPortal.Models
{
    public class Event
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }

        public string Title { get; set; }
        public string ImagePath { get; set; }
        public int TypeImage { get; set; }//1-big, 2-small
        public string Author { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
