namespace Domain.Entities
{
    public class CaracteristicasTransporte
    {
        public int CaracteristicaTransporteID { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public int CapacidadCarga { get; set; }
        public int CantidadAsientos { get; set; }
        public Transporte Transporte { get; set; }
        public int TransporteID { get; set; }
    }
}
