using Microsoft.AspNetCore.Mvc;

namespace TP04_paquetesturisticos.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.paquetes =OrtWorld.Paquetes;
        ViewBag.h=OrtWorld.hayPaquetes;
        return View();
    }
    public IActionResult SelectPaquete(){

        ViewBag.ListaAereos =OrtWorld.ListaAereos;
        ViewBag.ListaDestinos =OrtWorld.ListaDestinos;
        ViewBag.ListaHoteles =OrtWorld.ListaHotles;
        ViewBag.ListaExcursiones =OrtWorld.ListaExcursiones;

        ViewBag.error=false;
        return View();
    }
    public IActionResult GuardarPaquete(int destino, int hotel, int aereo, int excursion) {

        
        ViewBag.error= destino > 10 || destino <1 || hotel>10 || hotel<1 || aereo>10 || aereo<1 || excursion>10 || excursion<1;
        if (ViewBag.error) {
            ViewBag.ListaAereos =OrtWorld.ListaAereos;
            ViewBag.ListaDestinos =OrtWorld.ListaDestinos;
            ViewBag.ListaHoteles =OrtWorld.ListaHotles;
            ViewBag.ListaExcursiones =OrtWorld.ListaExcursiones;
            return View("Selectpaquete");
        }
        else {
        Paquete p = new Paquete(OrtWorld.ListaHotles[hotel-1], OrtWorld.ListaAereos[aereo-1], OrtWorld.ListaExcursiones[excursion-1]);
        OrtWorld.IngresarPaquete(OrtWorld.ListaDestinos[destino-1], p);

        ViewBag.h=OrtWorld.hayPaquetes;
        ViewBag.paquetes=OrtWorld.Paquetes;
        return View("Index");}    
    }
    public IActionResult BorrarPaquete(string destino) {
        
        ViewBag.paquetes =OrtWorld.Paquetes;
        ViewBag.h=OrtWorld.hayPaquetes;
        OrtWorld.BorrarPaquete(destino);
        return View("Index");
    }
}
