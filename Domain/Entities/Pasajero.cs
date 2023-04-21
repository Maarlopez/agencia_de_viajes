namespace Domain.Entities
{
    public class Pasajero
    {
        public int PasajeroID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public DateTime FechaNac { get; set; }
        public string Genero { get; set; }
        public int NumContactoEmergencia { get; set; }
        public ICollection<PasajeroViaje> PasajerosViaje { get; set; }
    }
}
