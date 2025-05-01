using Microsoft.AspNetCore.Mvc;

namespace MachinePrograms.Controllers
{
    public class WritingController : Controller
    {
        public IActionResult Essays()
        {
            return View();
        }
    }
}
