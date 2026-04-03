using Microsoft.AspNetCore.Mvc;
using Step.Hotel.Atr.RealPortal.Models;

namespace Step.Hotel.Atr.RealPortal.Controllers
{
    public class EventController : Controller
    {
        private readonly AppDbContext db;
        public EventController(AppDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            //var events = db.Events;//select * from Events
            List<Event> events = db.Events.ToList();//[]

            return View(events);
        }
    }
}
