namespace Domain.Entities
{
    public class Transporte
    {
        public int TransporteId { get; set; }

        public int TipoTransporteId { get; set; }
        public TipoTransporte TipoTransporte { get; set; }

        public int CompaniaTransporteId { get; set; }
        public CompaniaTransporte CompaniaTransporte { get; set; }

        public ICollection<CaracteristicaTransporte> CaracteristicasTransportes { get; set; }
        public ICollection<Viaje> Viajes { get; set; }

    }
}