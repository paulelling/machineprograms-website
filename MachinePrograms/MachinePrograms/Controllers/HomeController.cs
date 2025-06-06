using System.Diagnostics;
using MachinePrograms.Models;
using Microsoft.AspNetCore.Mvc;

namespace MachinePrograms.Controllers
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
    }
}
