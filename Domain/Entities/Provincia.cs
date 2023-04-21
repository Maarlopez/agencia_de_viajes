
namespace Domain.Entities
{
    public class Provincia
    {
        public int ProvinciaID { get; set; }
        public string Descripcion { get; set; }
        public Pais Paises { get; set; }
        public ICollection<Ciudad> Ciudades { get; set; }
    }
}
