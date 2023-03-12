using Microsoft.AspNetCore.Mvc;
using Prestamos_App.Services;
using Prestamos_App.ViewModel;

namespace PrestamosProject.Controllers
{
    public class PrestamosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(PrestamosViewModel pvm)
        {
           
            ViewData["cuotas"] = PrestamosServices.CalculoDeCuotas(pvm).ToString();
            return View();
        }
    }
}
