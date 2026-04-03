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
        public IActionResult ModifyTeam()
        {
            return View();
        }

        [HttpPost]
        //public IActionResult ModifyTeam(DateTime CreateDate, string PictureUrl) 
        public IActionResult ModifyTeam(Team team)
        {
            return View();
        }


    }
}
