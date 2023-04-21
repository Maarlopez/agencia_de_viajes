
namespace Domain.Entities
{
    public class Pasaje
    {
        public int PasajeID { get; set; }
        public Reserva Reservas { get; set; }
        public string Nota { get; set; }
    }
}
