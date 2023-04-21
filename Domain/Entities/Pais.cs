namespace Domain.Entities
{
    public class Pais
    {
        public int PaisID { get; set; }
        public string Descripcion { get; set; }
        public ICollection<Provincia> Provincias { get; set; }
    }
}
