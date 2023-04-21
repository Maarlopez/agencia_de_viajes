﻿namespace Domain.Entities
{
    public class Servicio
    {
        public int ServicioId { get; set; }
        public string Nombre { get; set; }
        public string Descripción { get; set; }
        public string Disponibilidad { get; set; }
        public int Precio { get; set; }

        public ICollection<ViajeServicio> ViajeServicios { get; set; }
    }
}
