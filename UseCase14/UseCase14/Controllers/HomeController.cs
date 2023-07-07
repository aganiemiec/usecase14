using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UseCase14.Models;

namespace UseCase14.Controllers
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
            var model = new IndexViewModel
            {
                CurrentDate = DateTime.Now,
                WeightOfMoon = 7347673E22,
                YourLuckyNumber = new Random().Next(100),
                LengthOfFootballField = 10000,
                CapacityOfGlass = 0.250,
            };

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}