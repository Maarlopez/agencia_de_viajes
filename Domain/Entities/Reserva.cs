namespace Domain.Entities
{
    public class Reserva
    {
        public int ReservaId { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public int Precio { get; set; }
        public int NumeroAsiento { get; set; }
        public string Clase { get; set; }

        public int PasajeroId { get; set; }
        public Pasajero Pasajero { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public int FacturaId { get; set; }
        public Factura Factura { get; set; }

        public int ViajeId { get; set; }
        public Viaje Viaje { get; set; }

        public ICollection<Pasaje> Pasajes { get; set; }
    }
}
