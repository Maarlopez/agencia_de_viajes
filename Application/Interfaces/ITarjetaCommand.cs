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
        Tarjeta InsertTarjeta(Tarjeta tarjeta);
        Tarjeta UpdateTarjeta(int tarjetaId);
        Tarjeta RemoveTarjeta(int tarjetaId);
    }
}
