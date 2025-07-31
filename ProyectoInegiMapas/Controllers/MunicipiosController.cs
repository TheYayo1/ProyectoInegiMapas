using Microsoft.AspNetCore.Mvc;
using ProyectoInegiMapas.Services;

namespace ProyectoInegiMapas.Controllers
{
    public class MunicipiosController : Controller
    {
        private readonly InegiApiService _inegi;

        public MunicipiosController(InegiApiService inegi)
        {
            _inegi = inegi;
        }

        public async Task<IActionResult> Index(string estado)
        {
            var municipios = await _inegi.ObtenerMunicipiosAsync(estado);
            return View(municipios);
        }
    }

}
