using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DarpinosPizzaria.Models;

namespace DarpinosPizzaria.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

}
