using Application.Request;
using Application.Response;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IUsuarioService
    {
        UsuarioResponse CreateUsuario(UsuarioRequest request);
        UsuarioResponse RemoveUsuario(int usuarioId);
        UsuarioResponse UpdateUsuario(int usuarioId, UsuarioRequest request);
        List<Usuario> GetUsuarioList();
        UsuarioResponse GetUsuarioById(int usuarioId);
    }
}
