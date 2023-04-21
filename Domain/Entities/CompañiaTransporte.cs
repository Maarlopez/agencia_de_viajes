namespace Domain.Entities
{
    public class CompañiaTransporte
    {
        public int CompañiaTransporteId { get; set; }
        public int Cuit { get; set; }
        public string RazonSocial { get; set; }

        public ICollection<TipoTransporte> TipoTransportes { get; set; }
    }
}