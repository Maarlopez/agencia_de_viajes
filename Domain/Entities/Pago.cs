namespace Domain.Entities
{
    public class Pago
    {
        public int PagoID { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public MetodoPago MetodosPago { get; set; }
        public Factura Facturas { get; set; }
    }
}
