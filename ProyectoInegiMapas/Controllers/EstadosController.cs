using Microsoft.AspNetCore.Mvc;
using ProyectoInegiMapas.Services;
using System.Threading.Tasks;

namespace ProyectoInegiMapas.Controllers
{
    public class EstadosController : Controller
    {
        private readonly InegiApiService _inegiService;

        public EstadosController(InegiApiService inegiService)
        {
            _inegiService = inegiService;
        }

        public async Task<IActionResult> Index()
        {
            var estados = await _inegiService.ObtenerEstadosAsync();
            return View(estados); // Necesitarás crear esta vista
        }
    }
}
