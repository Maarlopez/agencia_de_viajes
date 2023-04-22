using Application.Interfaces;
using Application.Request;
using Application.Response;
using Domain.Entities;
using System.Runtime.CompilerServices;

namespace Application.UseCase.Usuarios
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioCommand _command;
        private readonly IUsuarioQuery _query;

        public UsuarioService(IUsuarioCommand command, IUsuarioQuery query)
        {
            _command = command;
            _query = query;
        }

        public UsuarioResponse CreateUsuario(UsuarioRequest request)
        {
            var usuario = new Usuario
            {
                Nombre = request.Nombre,
                Apellido = request.Apellido,
                Email = request.Email,
                Domicilio = request.Domicilio,
                FechaNac = request.FechaNac,
                Nacionalidad = request.Nacionalidad,
                Telefono = request.Telefono,
                Dni = request.Dni
            };
            _command.InsertUsuario(usuario);
            return new UsuarioResponse
            {
                Nombre = usuario.Nombre,
                Apellido = usuario.Apellido,
                Dni = usuario.Dni
            };
        }

        public Usuario GetUsuarioById(int usuarioId)
        {
            return _query.GetUsuarioById(usuarioId);
        }

        public List<Usuario> GetUsuarioList()
        {
            return _query.GetUsuarioList();
        }

        public UsuarioResponse RemoveUsuario(int usuarioId)
        {
            var usuario = _command.RemoveUsuario(usuarioId);

            return new UsuarioResponse
            {
                Nombre = usuario.Nombre,
                Apellido = usuario.Apellido,
                Dni = usuario.Dni
            };
        }

        public Usuario UpdateUsuario(int usuarioId)
        {
            return _command.UpdateUsuario(usuarioId);
        }
    }
}
