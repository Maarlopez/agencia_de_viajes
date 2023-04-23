using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;

namespace Infrastructure.Query
{
    public class UsuarioQuery : IUsuarioQuery
    {
        private readonly AgenciaViajesContext _context;

        public UsuarioQuery(AgenciaViajesContext context)
        {
            _context = context;
        }

        public Usuario GetUsuarioById(int usuarioId)
        {
            var usuario = _context.Usuarios.FirstOrDefault(x => x.UsuarioId == usuarioId);
            return usuario;
        }

        public List<Usuario> GetUsuarioList()
        {
            List<Usuario> usuarioList = _context.Usuarios.ToList();
            return usuarioList;
        }
    }
}
