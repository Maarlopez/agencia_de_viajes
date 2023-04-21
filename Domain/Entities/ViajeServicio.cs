namespace Domain.Entities
{
    public class ViajeServicio
    {
        public int ViajeServicioID { get; set; }
        public Viaje Viajes { get; set; }
        public Servicio Servicios { get; set; }
    }
}
