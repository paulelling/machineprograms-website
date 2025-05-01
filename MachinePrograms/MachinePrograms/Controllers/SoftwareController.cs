using Microsoft.AspNetCore.Mvc;

namespace MachinePrograms.Controllers
{
    public class SoftwareController : Controller
    {
        public IActionResult Code()
        {
            return View();
        }

        public IActionResult Resources()
        {
            return View();
        }
    }
}
