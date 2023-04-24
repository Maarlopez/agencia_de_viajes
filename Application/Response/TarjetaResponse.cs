namespace Application.Response
{
    public class TarjetaResponse
    {
        public int TarjetaId { get; set; }
        public int NumeroTarjeta { get; set; }
        public string EntidadTarjeta { get; set; }
        public int UsuarioId { get; set; }
        public UsuarioResponse Usuario { get; set; }
    }
}
