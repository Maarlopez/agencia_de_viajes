namespace Domain.Entities
{
    public class Pasajero
    {
        public int PasajeroId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public DateTime FechaNac { get; set; }
        public string Genero { get; set; }
        public int NumContactoEmergencia { get; set; }

        public ICollection<PasajeroViaje> PasajerosViajes { get; set; }
    }
}
