namespace Domain.Entities
{
    public class Factura
    {
        public int FacturaID { get; set; }
        public Pago Pagos { get; set; } 
        public string Estado { get; set; }
        public int PrecioTotal { get; set; }
        public DateTime Fecha { get; set; }
    }
}
