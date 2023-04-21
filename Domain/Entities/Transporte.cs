namespace Domain.Entities
{
    public class Transporte
    {
        public int TransporteId { get; set; }

        public int TipoTransporteId { get; set; }
        public TipoTransporte TipoTransporte { get; set; }

        public int CompañiaTransporteId { get; set; }
        public CompañiaTransporte CompañiaTransporte { get; set; }

        public int CaracteristicaTransporteId { get; set; }
        public CaracteristicaTransporte CaracteristicaTransporte { get; set; }

        public ICollection<Viaje> Viajes { get; set; }

    }
}