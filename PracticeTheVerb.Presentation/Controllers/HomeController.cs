using Microsoft.AspNetCore.Mvc;
using PracticeTheVerb.Models;
using System.Diagnostics;

namespace PracticeTheVerb.Controllers
{
    [Controller]
    public class HomeController : Controller
    {
        public HomeController()
        {

        }
        
        [HttpGet("/")]
        public IActionResult Index()
        {
            var italianMainVerbs = new List<string>
            {
                "essere", "avere", "fare", "dire", "potere", "volere", "sapere", "stare", "dovere", "vedere",
                "andare", "venire", "dare", "parlare", "trovare", "sentire", "lasciare", "prendere", "guardare", "mettere"
            };

            ViewData["italianMainVerbs"] = italianMainVerbs;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}





