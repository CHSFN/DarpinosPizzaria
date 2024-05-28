using Microsoft.AspNetCore.Mvc;

namespace DarpinosPizzaria.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}