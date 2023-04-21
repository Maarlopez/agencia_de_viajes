namespace Domain.Entities
{
    public class Ciudad
    {
        public int CiudadId { get; set; }
        public string Descripcion { get; set; }

        public int ProvinciaId { get; set; }
        public Provincia Provincia { get; set; }

        public ICollection<Escala> Escalas { get; set; }
    }
}
