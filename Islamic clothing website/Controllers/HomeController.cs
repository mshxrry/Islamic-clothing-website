﻿using Islamic_clothing_website.Models;
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

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Fragrances()
        {
            return View();
        }
        public IActionResult Essentials()
        {
            return View();
        }
        public IActionResult Clothing()
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