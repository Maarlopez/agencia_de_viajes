using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Query
{
    public class TarjetaQuery : ITarjetaQuery
    {
        private readonly AgenciaViajesContext _context;

        public TarjetaQuery(AgenciaViajesContext context)
        {
            _context = context;
        }
        public Tarjeta GetTarjetaById(int tarjetaId)
        {
            var tarjeta = _context.Tarjetas
                .Include(p => p.Usuario)
                .FirstOrDefault(x => x.TarjetaId == tarjetaId);

            return tarjeta;
        }

        public List<Tarjeta> GetTarjetaList()
        {
            var listaTarjeta = _context.Tarjetas.OrderBy(fe => fe.TarjetaId).ToList();
            return listaTarjeta;
        }
    }
}
