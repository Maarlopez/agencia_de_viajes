namespace Domain.Entities
{
    public class Transporte
    {
        public int TransporteID { get; set; }
        public TipoTransporte TipoTransporte { get; set; }
        public CompañiaTransporte CompañiaTransporte { get; set; }
        public ICollection<Viaje> Viajes { get; set; }
        public CaracteristicasTransporte CaracteristicasTransporte { get; set; }
    }
}