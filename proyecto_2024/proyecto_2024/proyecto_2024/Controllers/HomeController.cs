using Microsoft.AspNetCore.Mvc;
using proyecto_2024.Models;
using System.Diagnostics;

namespace proyecto_2024.Controllers
{
    public class HomeController : Controller
    {

      


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
    }
}
