namespace Domain.Entities
{
    public class PasajeroViaje
    {
        public int PasajeroViajeId { get; set; }

        public int PasajeroId { get; set; }
        public Pasajero Pasajero { get; set; }

        public int ViajeId { get; set; }
        public Viaje Viaje { get; set; }

    }
}
