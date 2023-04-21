namespace Domain.Entities
{
    public class ViajeCiudad
    {
        public int ViajeCiudadId { get; set; }

        public int ViajeId { get; set; }
        public Viaje Viaje { get; set; }

        public int CiudadId { get; set; }
        public Ciudad Ciudad { get; set; }
    }
}
