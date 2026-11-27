using Microsoft.AspNetCore.Mvc;

namespace PcvtMyAppMVC.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
