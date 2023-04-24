namespace Application.Request
{
    public class TarjetaRequest
    {
        public int NumeroTarjeta { get; set; }
        public string TipoTarjeta { get; set; }
        public DateTime Vencimiento { get; set; }
        public string EntidadTarjeta { get; set; }
        public int usuarioId { get; set; }
    }
}
