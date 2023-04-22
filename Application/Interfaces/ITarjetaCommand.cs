using Domain.Entities;

namespace Application.Interfaces
{
    public interface ITarjetaCommand
    {
        Tarjeta InsertTarjeta(Tarjeta tarjeta);
        Tarjeta UpdateTarjeta(int tarjetaId);
        Tarjeta RemoveTarjeta(int tarjetaId);
    }
}
