using Microsoft.AspNetCore.Mvc;
using First_MVC_App.Models;

namespace First_MVC_App.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel dogModel = new DogViewModel() { Name="Sasha", Age = 12};
            return View(dogModel);
        }

    }
}
