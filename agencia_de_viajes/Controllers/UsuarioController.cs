using Application.Interfaces;
using Application.Request;
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

        [HttpGet("{usuarioId}")]
        public IActionResult GetUsuarioById(int usuarioId)
        {
            var result = _usuarioService.GetUsuarioById(usuarioId);

            if (result == null)
            {
                return NotFound(new { message = "No se encontraron Usuarios" });
            }

            return new JsonResult(result);
        }

        [HttpPost]
        public IActionResult CreateUsuario(UsuarioRequest request)
        {
            var result = _usuarioService.CreateUsuario(request);
            return new JsonResult(result);
        }

        [HttpPut("{usuarioId}")]
        public IActionResult UpdateUsuario(int usuarioId, UsuarioRequest request)
        {
            var result = _usuarioService.UpdateUsuario(usuarioId, request);
            return new JsonResult(result);
        }

        [HttpDelete("{usuarioId}")]
        public IActionResult DeleteUsuario(int usuarioId)
        {
            var result = _usuarioService.RemoveUsuario(usuarioId);
            return new JsonResult(result);
        }
    }
}
