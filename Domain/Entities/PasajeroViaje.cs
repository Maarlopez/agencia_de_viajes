namespace Domain.Entities
{
    public class PasajeroViaje
    {
        public int PasajeroViajeId { get; set; }

        public int PasajeroId { get; set; }
        public Pasajero Pasajero { get; set; }

        public ICollection<Viaje> Viajes { get; set; }

    }
}
