using Microsoft.AspNetCore.Mvc;

namespace firstproject.Controllers
{
    public class aboutController : Controller
    {
        public IActionResult Index()
        {
            String date = DateTime.Now.ToString();
                return Ok(date);
         //   return View();
        }
    }
}
