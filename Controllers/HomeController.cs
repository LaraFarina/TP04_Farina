using Microsoft.AspNetCore.Mvc;

namespace TP04_Farina.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Paquete = ORTWorld.Paquetes;
        return View();
    }
    public IActionResult SelectPaquete(){
        ViewBag.Destinos = ORTWorld.ListaDestinos;
        ViewBag.Hoteles = ORTWorld.ListaHoteles;
        ViewBag.Excursiones = ORTWorld.ListaExcursiones;
        ViewBag.Aereos = ORTWorld.ListaAereos;
        return View("Index");
    
    }
}
