using Domain.Entities;

namespace Application.Interfaces
{
    public interface IUsuarioQuery
    {
        List<Usuario> getUsuarioList();

        Usuario getUsuarioById(int usuarioId);
    }
}
