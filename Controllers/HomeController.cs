using Microsoft.AspNetCore.Mvc;

namespace TP04_paquetesturisticos.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.paquetes =OrtWorld.Paquetes;
        return View();
    }
    public IActionResult SelectPaquete(){

        ViewBag.ListaAereos =OrtWorld.ListaAereos;
        ViewBag.ListaDestinos =OrtWorld.ListaDestinos;
        ViewBag.ListaHoteles =OrtWorld.ListaHotles;
        ViewBag.ListaExcursiones =OrtWorld.ListaExcursiones;

        return View();
    }
}
