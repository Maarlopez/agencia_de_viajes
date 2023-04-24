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
        private readonly IUsuarioQuery _usuarioQuery;

        public TarjetaService(ITarjetaCommand command, ITarjetaQuery query, IUsuarioQuery usuarioQuery)
        {
            _command = command;
            _query = query;
            _usuarioQuery = usuarioQuery;
        }

        public TarjetaResponse CreateTarjeta(TarjetaRequest request)
        {
            var tarjeta = new Tarjeta
            {
                NumeroTarjeta = request.NumeroTarjeta,
                TipoTarjeta = request.TipoTarjeta,
                Vencimiento = request.Vencimiento,
                EntidadTarjeta = request.EntidadTarjeta,
                UsuarioId = request.usuarioId,
                Usuario = _usuarioQuery.GetUsuarioById(request.usuarioId)

            };

            _command.InsertTarjeta(tarjeta);
            return new TarjetaResponse
            {
                TarjetaId = tarjeta.TarjetaId,
                NumeroTarjeta = tarjeta.NumeroTarjeta,
                EntidadTarjeta = tarjeta.EntidadTarjeta,
                UsuarioId = tarjeta.UsuarioId,
                Usuario = new UsuarioResponse
                {
                    Nombre = _usuarioQuery.GetUsuarioById(request.usuarioId).Nombre,
                    Apellido = _usuarioQuery.GetUsuarioById(request.usuarioId).Apellido,
                    Dni = _usuarioQuery.GetUsuarioById(request.usuarioId).Dni,
                }
            };
        }

        public TarjetaResponse GetTarjetaById(int tarjetaId)
        {
            var tarjeta = _query.GetTarjetaById(tarjetaId);

            if (tarjeta != null)
            {
                return new TarjetaResponse
                {
                    TarjetaId = tarjeta.TarjetaId,
                    NumeroTarjeta = tarjeta.TarjetaId,
                    EntidadTarjeta = tarjeta.EntidadTarjeta,
                    UsuarioId = tarjeta.UsuarioId,
                    Usuario = new UsuarioResponse
                    {
                        Nombre = tarjeta.Usuario.Nombre,
                        Apellido = tarjeta.Usuario.Apellido,
                        Dni = tarjeta.Usuario.Dni
                    }
                };
            }
            return null;
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
                EntidadTarjeta = tarjeta.EntidadTarjeta,
                UsuarioId = tarjeta.UsuarioId,
                Usuario = new UsuarioResponse
                {
                    Nombre = tarjeta.Usuario.Nombre,
                    Apellido = tarjeta.Usuario.Apellido,
                    Dni = tarjeta.Usuario.Dni
                }
            };

        }
    }
}