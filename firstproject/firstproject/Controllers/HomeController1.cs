using Microsoft.AspNetCore.Mvc;

namespace firstproject.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
