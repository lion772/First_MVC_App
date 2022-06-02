using Microsoft.AspNetCore.Mvc;

namespace First_MVC_App.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
