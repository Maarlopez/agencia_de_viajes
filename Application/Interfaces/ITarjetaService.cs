using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ITarjetaService
    {
        Tarjeta CreateTarjeta(int numeroTarjeta, string tipoTarjeta, DateTime vencimiento, string entidadTarjeta);
        Tarjeta RemoveTarjeta(int tarjetaId);
        Tarjeta UpdateTarjeta(int tarjetaId);
        List<Tarjeta> GetTarjetaList();
        Tarjeta GetTarjetaById(int tarjetaId);
    }
}
