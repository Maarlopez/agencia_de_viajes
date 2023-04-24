﻿using Application.Interfaces;
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
    }
}
