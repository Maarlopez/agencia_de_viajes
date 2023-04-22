namespace Domain.Entities
{
    public class CompaniaTransporte
    {
        public int CompaniaTransporteId { get; set; }
        public int Cuit { get; set; }
        public string RazonSocial { get; set; }

        public ICollection<Transporte> Transportes { get; set; }
    }
}