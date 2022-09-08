using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using System.Reflection;

namespace MVCDemo.Controllers
{
    public class EventsController : Controller
    {
        public List<BookingEvents> events { get; set; }
        public IActionResult Index()
        {
            events = new List<BookingEvents>();
            events.Add(new BookingEvents { Title = "ask CEO", EventDate = DateTime.Today, Qty = 10 });
            return View(events);
        }
    }
}