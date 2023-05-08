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
    public IActionResult GuardarPaquete(int destino, int hotel, int aereo, int excursion) {

        if (destino > 10 || destino <1 || hotel>10 || hotel<1 || aereo>10 || aereo<1 || excursion>10 || excursion<1) {
            ViewBag.exeption = "Error: datos no validos";
            return View(SelectPaquete);
        }
        Paquete p = new Paquete(OrtWorld.ListaHotles[hotel-1], OrtWorld.ListaAereos[aereo-1], OrtWorld.ListaExcursiones[excursion-1]);
        bool e = OrtWorld.IngresarPaquete(OrtWorld.ListaDestinos[destino-1], p);
        ViewBag.ListaAereos =OrtWorld.ListaAereos;
        ViewBag.ListaDestinos =OrtWorld.ListaDestinos;
        ViewBag.ListaHoteles =OrtWorld.ListaHotles;
        ViewBag.ListaExcursiones =OrtWorld.ListaExcursiones;
        return View(Index);
    }
}
