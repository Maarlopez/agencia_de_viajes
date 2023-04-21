namespace Domain.Entities
{
    public class MetodoPago
    {
        public int MetodoPagoID { get; set; }
        public string Descripcion { get; set; }
        public ICollection<Pago> Pagos { get; set; }
    }
}
