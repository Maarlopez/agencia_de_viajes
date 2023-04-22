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
    }
}
