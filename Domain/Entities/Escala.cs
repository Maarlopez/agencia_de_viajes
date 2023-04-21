namespace Domain.Entities
{
    public class Escala
    {
        public int EscalaID { get; set; }
        public Viaje Viajes { get; set; }
        public string NombreParada { get; set; }
        public int HoraLlegada { get; set; }
        public int HoraSalida { get; set; }
        public int Duracion { get; set; }
        public Ciudad Ciudad { get; set; }
    }
}
