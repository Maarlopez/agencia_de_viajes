namespace Domain.Entities
{
    public class Pago
    {
        public int PagoId { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }

        public int MetodoPagoId { get; set; }
        public MetodoPago MetodoPago { get; set; }

        public Factura Factura { get; set; }
    }
}
