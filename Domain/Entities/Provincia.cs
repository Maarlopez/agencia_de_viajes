
namespace Domain.Entities
{
    public class Provincia
    {
        public int ProvinciaId { get; set; }
        public string Descripcion { get; set; }

        public int PaisId { get; set; }
        public Pais Pais { get; set; }

        public ICollection<Ciudad> Ciudades { get; set; }
    }
}
