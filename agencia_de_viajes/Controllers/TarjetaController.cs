using Application.Interfaces;
using Microsoft.AspNetCore.Http;
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
    }
}
