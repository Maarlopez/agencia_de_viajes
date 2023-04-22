using Application.Interfaces;
using Application.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace agencia_de_viajes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public IActionResult GetUsuarioById(int id)
        {
            var result = _usuarioService.GetUsuarioById(id);
            return new JsonResult(result);
        }

        [HttpPost]
        public IActionResult CreateUsuario(UsuarioRequest request)
        {
            var result = _usuarioService.CreateUsuario(request);
            return new JsonResult(result);
        }

        [HttpDelete]
        public IActionResult DeleteUsuario(int id)
        {
            var result = _usuarioService.RemoveUsuario(id);
            return new JsonResult(result);
        }

    }
}
