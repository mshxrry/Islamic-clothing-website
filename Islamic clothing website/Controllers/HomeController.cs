using Islamic_clothing_website.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Islamic_clothing_website.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        /* This code creates seperate pages of the products */
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult PrayerMats()
        {
            return View();
        }

        public IActionResult MensCaps()
        {
            return View();
        }

        public IActionResult WomenHijabs()
        {
            return View();
        }

        public IActionResult OtherItems()
        {
            return View();
        }

        public IActionResult ShopMenFragrances()
        {
            return View();
        }

        public IActionResult ShopWomenFragrances()
        {
            return View();
        }

        public IActionResult ShopMenClothing()
        {
            return View();
        }

        public IActionResult ShopWomenClothing()
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