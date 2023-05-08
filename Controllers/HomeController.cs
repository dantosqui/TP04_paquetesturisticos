using Microsoft.AspNetCore.Mvc;

namespace TP04_paquetesturisticos.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
