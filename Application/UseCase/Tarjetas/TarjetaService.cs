using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase.Tarjetas
{
    public class TarjetaService : ITarjetaService
    {
        private readonly ITarjetaCommand _command;
        private readonly ITarjetaQuery _query;

        public TarjetaService(ITarjetaCommand command, ITarjetaQuery query)
        {
            _command = command;
            _query = query;
        }

        public Tarjeta CreateTarjeta(int numeroTarjeta, string tipoTarjeta, DateTime vencimiento, string entidadTarjeta)
        {

            var tarjeta = new Tarjeta
            {
                NumeroTarjeta = numeroTarjeta,
                TipoTarjeta = tipoTarjeta,
                Vencimiento = vencimiento,
                EntidadTarjeta = entidadTarjeta
            };

            return _command.InsertTarjeta(tarjeta);
        }

        public Tarjeta GetTarjetaById(int tarjetaId)
        {
            return _query.GetTarjetaById(tarjetaId);
        }

        public List<Tarjeta> GetTarjetaList()
        {
            return _query.GetTarjetaList();
        }

        public Tarjeta RemoveTarjeta(int tarjetaId)
        {
            return _command.RemoveTarjeta(tarjetaId);
        }

        public Tarjeta UpdateTarjeta(int tarjetaId)
        {
            return _command.UpdateTarjeta(tarjetaId);
        }
    }
}
