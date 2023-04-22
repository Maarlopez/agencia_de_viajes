using Application.Request;
using Application.Response;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IUsuarioService
    {
        UsuarioResponse CreateUsuario(UsuarioRequest request);
        UsuarioResponse RemoveUsuario(int usuarioId);
        Usuario UpdateUsuario(int usuarioId);
        List<Usuario> GetUsuarioList();
        Usuario GetUsuarioById(int usuarioId);
    }
}
