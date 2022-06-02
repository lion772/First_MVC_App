using Microsoft.AspNetCore.Mvc;

namespace First_MVC_App.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Hello()
        {
            return "Who's there?";
        }
    }
}
