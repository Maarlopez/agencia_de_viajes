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
        public void Delete(int tarjetaId)
        {
            Tarjeta tarjeta = _context.Tarjetas.Find(tarjetaId);
            _context.Remove(tarjeta);
            _context.SaveChanges();
        }

        public void Insert(Tarjeta tarjeta)
        {
            _context.Add(tarjeta);
            _context.SaveChanges();
        }

        public void Update(int tarjetaId)
        {
            Tarjeta tarjeta = _context.Tarjetas.Find(tarjetaId);
            _context.Entry(tarjeta).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
