using System.Diagnostics;
using Entityframeworkcore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Entityframeworkcore.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        public IActionResult SaveSession()
        {
            HttpContext.Session.SetString("username", "sunita khakurel");
           
            return View();
        }
      
        public IActionResult GetSessionData()
        {
            string name=HttpContext.Session.GetString("username");
            return Content(name);


            
        }
    }
}


//var CookieValue = Request.Cookies["username"];
//return Content(CookieValue);
