namespace Domain.Entities
{
    public class ViajeCiudad
    {
        public int ViajeCiudadID { get; set; }
        public Viaje Viajes { get; set; }
        public Ciudad Ciudades { get; set; }
    }
}
