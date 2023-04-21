namespace Domain.Entities
{
    public class Escala
    {
        public int EscalaId { get; set; }
        public string NombreParada { get; set; }
        public TimeOnly HoraLlegada { get; set; }
        public TimeOnly HoraSalida { get; set; }
        public int Duracion { get; set; }

        public int ViajeId { get; set; }
        public Viaje Viaje { get; set; }

        public int CiudadId { get; set; }
        public Ciudad Ciudad { get; set; }
    }
}
