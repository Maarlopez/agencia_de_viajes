using Application.Request;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface ITarjetaCommand
    {
        Tarjeta InsertTarjeta(Tarjeta tarjeta);
        Tarjeta UpdateTarjeta(int tarjetaId,TarjetaRequest request);
        Tarjeta RemoveTarjeta(int tarjetaId);
    }
}
