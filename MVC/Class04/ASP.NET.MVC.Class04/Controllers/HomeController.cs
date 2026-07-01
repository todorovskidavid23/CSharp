using ASP.NET.MVC.Class04.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP.NET.MVC.Class04.Controllers
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
            //dinamicki da si isprakjame data 
            //viewbag samo sto ne odi so key value parovi so pomos na tocka . kako objekt ViewBag.Key="Value"
            //da se vikne @ViewBag.Message
            //View Model pri run ne se fakjaat i greska da se napravi nema da javi greska NE SE BUILDA VIEWBAG I VIEDATA
            //podobar e ViewModel MNOGU VAZNO go vrakjame celo view 
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
