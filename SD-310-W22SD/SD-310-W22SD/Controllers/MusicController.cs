using Microsoft.AspNetCore.Mvc;

namespace SD_310_W22SD.Controllers
{
    public class MusicController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
