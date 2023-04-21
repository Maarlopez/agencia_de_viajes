namespace Domain.Entities
{
    public class Tarjeta
    {
        public int TarjetaID { get; set; }
        public int NumeroTarjeta { get; set; }
        public string TipoTarjeta { get; set; }
        public DateTime Vencimiento { get; set; }
        public Usuario Usuarios { get; set; }
        public string EntidadTarjeta { get; set; }
    }
}