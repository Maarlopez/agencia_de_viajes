using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUsuarioService
    {
        Usuario CreateUsuario(string nombre,string apellido,int dni,DateTime fechaNac,string email,string nacionalidad,int telefono,string domicilio);
        Usuario RemoveUsuario(int usuarioId);
        Usuario UpdateUsuario(int usuarioId);
        List<Usuario> GetUsuarioList();
        Usuario GetUsuarioById(int usuarioId);
    }
}
