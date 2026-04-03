using Microsoft.AspNetCore.Mvc;
using Step.Hotel.Atr.Admin.Data;
using Step.Hotel.Atr.Admin.Models;
using System.Diagnostics;

namespace Step.Hotel.Atr.Admin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HotelAtrDbContext _db;

        public HomeController(ILogger<HomeController> logger, HotelAtrDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TeamList()
        {
            List<Team> data = _db.Teams.ToList();

            return View(data);
        }


        [HttpGet]
        public IActionResult ModifyTeam(int Id = 0)
        {
            Team team = new Team();
            if (Id != 0)
                team = _db.Teams.Find(Id);

            return View(team);
        }

        [HttpPost]
        //public IActionResult ModifyTeam(DateTime CreateDate, string PictureUrl) 
        public IActionResult ModifyTeam(Team team)
        {
            if (team.Id != 0)
            {
                var data = _db.Teams.Find(team.Id);
                data.FullName = team.FullName;
                data.Desctiption = team.Desctiption;
                data.CreateDate = team.CreateDate;
                data.PictureUrl = team.PictureUrl;
                data.Position = team.Position;
            }
            else
                _db.Teams.Add(team);

            _db.SaveChanges();

            return RedirectToAction("TeamList");
        }

        public IActionResult DeleteTeam(int Id)
        {
            if (Id != 0)
            {
                var data = _db.Teams.Find(Id);
                if(data!=null)
                {
                    _db.Teams.Remove(data);
                    _db.SaveChanges();
                }
            }

            return RedirectToAction("TeamList");
        }
    }
}
