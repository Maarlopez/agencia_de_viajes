using Application.Request;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IUsuarioCommand
    {
        Usuario InsertUsuario(Usuario usuario);

        Usuario RemoveUsuario(int usuarioId);

        Usuario UpdateUsuario(int usuarioId, UsuarioRequest request);

    }
}
