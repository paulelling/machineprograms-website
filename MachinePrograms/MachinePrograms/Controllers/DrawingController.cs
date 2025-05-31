using Microsoft.AspNetCore.Mvc;

namespace MachinePrograms.Controllers
{
    public class DrawingController : Controller
    {
        public IActionResult Sketches()
        {
            return View();
        }
    }
}
