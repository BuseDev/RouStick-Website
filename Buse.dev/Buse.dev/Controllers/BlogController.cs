using Microsoft.AspNetCore.Mvc;

namespace Buse.dev.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult BlogIndex()
        {
            return View();
        }
    }
}
