using Microsoft.AspNetCore.Mvc;

namespace MachinePrograms.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }
    }
}
