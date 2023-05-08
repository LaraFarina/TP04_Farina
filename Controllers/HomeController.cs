using Microsoft.AspNetCore.Mvc;

namespace TP04_Farina.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
