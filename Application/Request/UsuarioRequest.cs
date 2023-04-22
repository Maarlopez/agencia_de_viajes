using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request
{
    public class UsuarioRequest
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public DateTime FechaNac { get; set; }
        public string Email { get; set; }
        public string Nacionalidad { get; set; }
        public int Telefono { get; set; }
        public string Domicilio { get; set; }
    }
}
