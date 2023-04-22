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
            var removeUsuario = _context.Usuarios.Single(x => x.UsuarioId == usuarioId);
            _context.Remove(removeUsuario);
            _context.SaveChanges();
            return removeUsuario;
        }

        public Usuario UpdateUsuario(int usuarioId)
        {
            var updateUsuario = _context.Usuarios.Single(x => x.UsuarioId == usuarioId);
            _context.Update(updateUsuario);
            _context.SaveChanges();
            return updateUsuario;
        }
    }
}
