using Domain.Entities;

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
