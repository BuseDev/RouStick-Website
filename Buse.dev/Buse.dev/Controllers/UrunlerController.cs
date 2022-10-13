using Microsoft.AspNetCore.Mvc;

namespace Buse.dev.Controllers
{
    public class UrunlerController : Controller
    {
        public IActionResult UrunlerIndex()
        {
            return View();
        }
    }
}
