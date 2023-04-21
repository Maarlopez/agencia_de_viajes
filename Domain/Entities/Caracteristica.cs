namespace Domain.Entities
{
    public class Caracteristica
    {
        public int CaracteristicaId { get; set; }
        public string Descripcion { get; set; }

        public ICollection<CaracteristicaTransporte> CaracteristicasTransportes { get; set; }
    }
}
