using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieContext blahContext { get; set; }
        // constructor 
        public HomeController(ILogger<HomeController> logger, MovieContext randomName)
        {
            _logger = logger;
            blahContext = randomName;
        }
        // sets up view for index page
        public IActionResult Index()
        {
            return View();
        }
        // sets up view for podcast page
        public IActionResult MyPodcasts()
        {
            return View();
        }
        // get method for entering a movie into the database
        [HttpGet]
        public IActionResult EnterMovie()
        {
            return View();
        }
        // post method for entering a movie into the database
        [HttpPost]
        public IActionResult EnterMovie(FormResponse ar)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }
            blahContext.Add(ar);
            blahContext.SaveChanges();
            return View("confirmation", ar);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
