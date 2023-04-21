namespace Domain.Entities
{
    public class Viaje
    {
        public int ViajeId { get; set; }
        public int Duracion { get; set; }
        public int HorarioSalida { get; set; }
        public int HorarioLlegada { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaLlegada { get; set; }
        public string TipoViaje { get; set; }
        public Transporte Transporte { get; set; }
        public PasajeroViaje PasajeroViaje { get; set; }
        public ICollection<Escala> Escalas { get; set; }
        public ICollection<ViajeCiudad> ViajeCiudades { get; set; }
        public ICollection<ViajeServicio> ViajeServicios { get; set; }
        public ICollection<Reserva> Reservas { get; set; }
        public ICollection<PasajeroViaje> PasajeroViajes { get; set; }

    }
}