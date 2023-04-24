using Application.Interfaces;
using Application.Request;
using Application.Response;
using Domain.Entities;

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

        public TarjetaResponse CreateTarjeta(TarjetaRequest request)
        {
            var tarjeta = new Tarjeta
            {
                NumeroTarjeta = request.NumeroTarjeta,
                TipoTarjeta = request.TipoTarjeta,
                Vencimiento = request.Vencimiento,
                EntidadTarjeta = request.EntidadTarjeta,
                UsuarioId = request.usuarioId
            };
            _command.InsertTarjeta(tarjeta);
            return new TarjetaResponse
            {
                TarjetaId = tarjeta.TarjetaId,
                NumeroTarjeta = tarjeta.NumeroTarjeta,
                EntidadTarjeta = tarjeta.EntidadTarjeta,
                UsuarioId = tarjeta.UsuarioId
            };
        }

        public TarjetaResponse GetTarjetaById(int tarjetaId)
        {
            var tarjeta = _query.GetTarjetaById(tarjetaId);
            return new TarjetaResponse
            {
                TarjetaId = tarjeta.TarjetaId,
                NumeroTarjeta = tarjeta.TarjetaId,
                EntidadTarjeta = tarjeta.EntidadTarjeta
            };
        }

        public List<Tarjeta> GetTarjetaList()
        {
            return _query.GetTarjetaList();
        }

        public TarjetaResponse RemoveTarjeta(int tarjetaId)
        {
            var tarjeta = _command.RemoveTarjeta(tarjetaId);

            return new TarjetaResponse
            {
                TarjetaId = tarjeta.TarjetaId,
                NumeroTarjeta = tarjeta.NumeroTarjeta,
                EntidadTarjeta = tarjeta.EntidadTarjeta
            };
        }

        public TarjetaResponse UpdateTarjeta(int tarjetaId, TarjetaRequest request)
        {
            var tarjeta = _command.UpdateTarjeta(tarjetaId, request);
            return new TarjetaResponse
            {
                TarjetaId = tarjeta.TarjetaId,
                NumeroTarjeta = tarjeta.NumeroTarjeta,
                EntidadTarjeta = tarjeta.EntidadTarjeta
            };

        }

    }
}


//private readonly ITarjetaCommand _command;
//private readonly ITarjetaQuery _query;

//public TarjetaService(ITarjetaCommand command, ITarjetaQuery query)
//{
//    _command = command;
//    _query = query;
//}

//public Tarjeta CreateTarjeta(int numeroTarjeta, string tipoTarjeta, DateTime vencimiento, string entidadTarjeta)
//{

//    var tarjeta = new Tarjeta
//    {
//        NumeroTarjeta = numeroTarjeta,
//        TipoTarjeta = tipoTarjeta,
//        Vencimiento = vencimiento,
//        EntidadTarjeta = entidadTarjeta
//    };

//    return _command.InsertTarjeta(tarjeta);
//}

//public Tarjeta GetTarjetaById(int tarjetaId)
//{
//    return _query.GetTarjetaById(tarjetaId);
//}

//public List<Tarjeta> GetTarjetaList()
//{
//    return _query.GetTarjetaList();
//}

//public Tarjeta RemoveTarjeta(int tarjetaId)
//{
//    return _command.RemoveTarjeta(tarjetaId);
//}

//public Tarjeta UpdateTarjeta(int tarjetaId)
//{
//    return _command.UpdateTarjeta(tarjetaId);
//}