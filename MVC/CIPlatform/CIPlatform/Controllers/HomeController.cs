using CIPlatform.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CIPlatform.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Lost()
        {
            return View();
        }


        public IActionResult Registration()
        {
            return View();
        }


        public IActionResult Reset()
        {
            return View();
        }

        public IActionResult Platform()
        {
            return View();
        }
        
        public IActionResult NoMissionFound()
        {
            return View();
        }

        public IActionResult VolunteeringMission()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}