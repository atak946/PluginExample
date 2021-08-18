using Microsoft.AspNetCore.Mvc;

namespace Plugin.Controllers
{
    public class TestPlgController : Controller
    {
        public TestPlgController()
        {
        }

        public IActionResult Test()
        {
            return View();
        }
    }
}
