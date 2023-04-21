namespace Domain.Entities
{
    public class CompañiaTransporte
    {
        public int CompañiaTransporteID { get; set; }
        public int CUIT { get; set; }
        public string RazonSocial { get; set; }
        public ICollection<TipoTransporte> TipoTransportes { get; set; }
    }
}