using Microsoft.AspNetCore.Mvc;

namespace MachinePrograms.Controllers
{
    public class STEMController : Controller
    {
        public IActionResult Technology()
        {
            return View();
        }

        public IActionResult Resources()
        {
            return View();
        }
    }
}
