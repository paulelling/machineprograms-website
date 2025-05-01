using Microsoft.AspNetCore.Mvc;

namespace MachinePrograms.Controllers
{
    public class LeadershipController : Controller
    {
        public IActionResult Guidelines()
        {
            return View();
        }
    }
}
