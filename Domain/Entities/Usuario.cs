namespace Domain.Entities
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public DateTime FechaNac { get; set; }
        public string Email { get; set; }
        public string Nacionalidad { get; set; }
        public int Telefono { get; set; }
        public int TarjetaID { get; set; }
        public string Domicilio { get; set; }
        public ICollection<Tarjeta> Tarjetas { get; set; }
        public ICollection<Reserva> Reservas { get; set; }
    }
}