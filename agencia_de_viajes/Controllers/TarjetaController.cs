using Application.Interfaces;
using Application.Request;
using Microsoft.AspNetCore.Mvc;

namespace agencia_de_viajes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarjetaController : ControllerBase
    {
        private readonly ITarjetaService _tarjetaService;

        public TarjetaController(ITarjetaService tarjetaService)
        {
            _tarjetaService = tarjetaService;
        }

        [HttpPost]
        public IActionResult CreateTarjeta(TarjetaRequest request)
        {
            var result = _tarjetaService.CreateTarjeta(request);
            return new JsonResult(result);
        }

        [HttpGet("{tarjetaId}")]
        public IActionResult GetTarjetaById(int tarjetaId)
        {
            var result = _tarjetaService.GetTarjetaById(tarjetaId);

            if (result == null)
            {
                return NotFound(new { message = "No se encontraron tarjetas" });
            }

            return new JsonResult(result);
        }

        [HttpDelete("{tarjetaId}")]
        public IActionResult DeleteTarjeta(int tarjetaId)
        {
            var result = _tarjetaService.RemoveTarjeta(tarjetaId);
            return new JsonResult(result);
        }

        [HttpPut("{tarjetaId}")]
        public IActionResult UpdateTarjeta(int tarjetaId, TarjetaRequest request)
        {
            var result = _tarjetaService.UpdateTarjeta(tarjetaId, request);
            return new JsonResult(result);
        }
    }
}
