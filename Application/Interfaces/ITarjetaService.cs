using Application.Request;
using Application.Response;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface ITarjetaService
    {
        TarjetaResponse CreateTarjeta(TarjetaRequest tarjeta);
        TarjetaResponse RemoveTarjeta(int tarjetaId);
        TarjetaResponse UpdateTarjeta(int tarjetaId, TarjetaRequest tarjeta);
        List<Tarjeta> GetTarjetaList();
        TarjetaResponse GetTarjetaById(int tarjetaId);
    }
}
