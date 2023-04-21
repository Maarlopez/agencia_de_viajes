namespace Domain.Entities
{
    public class Reserva
    {
        public int ReservaID { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public int Precio { get; set; }
        public int NumeroAsiento { get; set; }
        public string Clase { get; set; }
        public Pasajero Pasajeros { get; set; }
        public Usuario Usuarios { get; set; }
        public Factura Facturas { get; set; }
        public ICollection<Pasaje> Pasajes { get; set; }
    }
}
