using Microsoft.AspNetCore.Mvc;

namespace CafePage.Controllers
{
    public class GiftController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
