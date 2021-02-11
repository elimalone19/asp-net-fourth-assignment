using asp_net_fourth_assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace asp_net_fourth_assignment.Controllers
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
            List<string> RestList = new List<string>();

            foreach(Restaurant r in Restaurant.GetRestaurants())
            {
                RestList.Add("#" + r.Rank + "- " + r.Name + ", Top Dish: " + r.Dish + ", Address: " + r.Address + ", Number: " + r.Phone + ", Link: " + r.Link);
            }

            return View(RestList);
        }

        public IActionResult See()
        {
            return View(Temp.Suggestions);
        }

        [HttpGet]
        public IActionResult Submit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit(Suggestions Suggestion)
        {
            if (ModelState.IsValid)
            { //checking model state
                Temp.AddSuggestion(Suggestion);
                return View("Confirmation", Suggestion);
            }
            return View();
        }

        public IActionResult Privacy()
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
