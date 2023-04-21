namespace Domain.Entities
{
    public class PasajeroViaje
    {
        public int PasajeroViajeID { get; set; }
        public Pasajero? Pasajeros { get; set; }
        public ICollection<Viaje> Viajes { get; set; }

    }
}
