using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;

namespace Infrastructure.Command
{
    public class UsuarioCommand : IUsuarioCommand
    {
        private readonly AgenciaViajesContext _context;

        public UsuarioCommand(AgenciaViajesContext context)
        {
            _context = context;
        }

        public Usuario InsertUsuario(Usuario usuario)
        {
            _context.Add(usuario);
            _context.SaveChanges();
            return usuario;
        }

        public Usuario RemoveUsuario(int usuarioId)
        {
            var removeUsuarioId = _context.Usuarios.Single(x => x.UsuarioId == usuarioId);
            _context.Remove(removeUsuarioId);
            _context.SaveChanges();
            return removeUsuarioId;
        }

        public Usuario UpdateUsuario(int usuarioId)
        {
            var updateUsuarioId = _context.Usuarios.Single(x => x.UsuarioId == usuarioId);
            _context.Update(updateUsuarioId);
            _context.SaveChanges();
            return updateUsuarioId;
        }
    }
}
