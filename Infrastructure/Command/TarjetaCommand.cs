using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Infrastructure.Command
{
    public class TarjetaCommand : ITarjetaCommand
    {
        private readonly AgenciaViajesContext _context;

        public TarjetaCommand(AgenciaViajesContext context)
        {
            _context = context;
        }
        public Tarjeta RemoveTarjeta(int tarjetaId)
        {
            var removeTarjeta = _context.Tarjetas.Single(x => x.TarjetaId == tarjetaId);
            _context.Remove(removeTarjeta);
            _context.SaveChanges();
            return removeTarjeta;
        }

        public Tarjeta InsertTarjeta(Tarjeta tarjeta)
        {
            _context.Add(tarjeta);
            _context.SaveChanges();
            return tarjeta;
        }

        public Tarjeta UpdateTarjeta(int tarjetaId)
        {
            var updateTarjeta = _context.Tarjetas.Single(x => x.TarjetaId == tarjetaId);
            _context.Update(updateTarjeta);
            _context.SaveChanges();
            return updateTarjeta;
        }
    }
}
