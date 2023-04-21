namespace Domain.Entities
{
    public class TipoTransporte
    {
        public int TipoTransporteID { get; set; }
        public string Descripcion { get; set; }
        public ICollection<Transporte> Transportes { get; set; }
    }
}