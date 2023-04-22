using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ITarjetaCommand
    {
        void Insert(Tarjeta tarjeta);
        void Update(int tarjetaId);
        void Delete(int tarjetaId);
    }
}
