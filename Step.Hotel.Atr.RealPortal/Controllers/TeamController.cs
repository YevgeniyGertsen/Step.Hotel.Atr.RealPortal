using Microsoft.AspNetCore.Mvc;
using Step.Hotel.Atr.RealPortal.Models;

namespace Step.Hotel.Atr.RealPortal.Controllers
{
    public class TeamController : Controller
    {
        private AppDbContext db;
        public TeamController(AppDbContext _db)
        {
           db = _db;
        }

        public IActionResult Index()
        {
            ViewDataTeamIndex data = new ViewDataTeamIndex();
            data.Teams = db.Teams.ToList();
            data.Clients = db.Clients.ToList();

            return View(data);
        }
    }
}
