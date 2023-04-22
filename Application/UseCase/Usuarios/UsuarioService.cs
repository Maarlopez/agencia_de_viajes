using Application.Interfaces;
using Domain.Entities;

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

        public Usuario CreateUsuario(string nombre, string apellido, int dni, DateTime fechaNac, string email, string nacionalidad, int telefono, string domicilio)
        {
            var usuario = new Usuario
            {
                Nombre = nombre,
                Apellido = apellido,
                Email = email,
                Domicilio = domicilio,
                FechaNac = fechaNac,
                Nacionalidad = nacionalidad,
                Telefono = telefono,
                Dni = dni
            };

           return _command.InsertUsuario(usuario);
        }

        public Usuario GetUsuarioById(int usuarioId)
        {
            return _query.GetUsuarioById(usuarioId);
        }

        public List<Usuario> GetUsuarioList()
        {
            return _query.GetUsuarioList();
        }

        public Usuario RemoveUsuario(int usuarioId)
        {
            return _command.RemoveUsuario(usuarioId);
        }

        public Usuario UpdateUsuario(int usuarioId)
        {
            return _command.UpdateUsuario(usuarioId);
        }
    }
}
