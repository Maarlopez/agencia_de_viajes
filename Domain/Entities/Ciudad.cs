namespace Domain.Entities
{
    public class Ciudad
    {
        public int CiudadID { get; set; }
        public string Descripcion { get; set; }
        public Provincia Provincias { get; set; }
        public ICollection<Escala> Escalas { get; set; }
    }
}
