using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using MVCDemo.PizzaService;

namespace MVCDemo.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> pizzas = PizzaService.PizzaService.GetAll();
            return View(pizzas);
        }

        public IActionResult Details(int id)
        {
            Pizza p = PizzaService.PizzaService.Get(id);
            return View(p);
        }

        public IActionResult List()
        {
            List<Pizza> pizzas = PizzaService.PizzaService.GetAll();
            return View(pizzas);
        }

        public IActionResult Create()
        {
            return View();
        }
        //  public IActionResult Create(int id, string name, int size, decimal price, bool Isglutenfree)
        [HttpPost]
            public IActionResult Create(Pizza p)
        {
            PizzaService.PizzaService.Add(p);
            return RedirectToAction("List");
        }
         public IActionResult Delete(int id)
        {
            Pizza p = PizzaService.PizzaService.Get(id);
            if (p != null)
                return View(p);
            else
                return RedirectToAction("List");
        }
        [HttpPost]
        public IActionResult Delete(Pizza p)
        {
            PizzaService.PizzaService.Delete(p.Id);
            return RedirectToAction("List");

        }
    }
}




