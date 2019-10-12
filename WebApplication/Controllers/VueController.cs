using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class VueController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WatchExamples()
        {
            return View();
        }
        public IActionResult Component()
        {
            return View();
        }
    }
}