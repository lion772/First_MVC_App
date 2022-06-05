using Microsoft.AspNetCore.Mvc;
using First_MVC_App.Models;

namespace First_MVC_App.Controllers
{
    public class HotelBookingController : Controller
    {
        private HotelBooking hotels = new HotelBooking();

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Hotel()
        {
            var hotelVM = new HotelBooking() { GuestName = "Will" };
            return View(hotelVM);
        }
    }
}
