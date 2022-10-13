using Microsoft.AspNetCore.Mvc;

namespace Buse.dev.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult ShopIndex()
        {
            return View();
        }
    }
}
