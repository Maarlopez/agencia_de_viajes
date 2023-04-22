using Domain.Entities;
using Infrastructure.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class AgenciaViajesContext : DbContext
    {
        public DbSet<ViajeServicio> ViajeServicios { get; set; }

        public DbSet<ViajeCiudad> ViajeCiudades { get; set; }

        public DbSet<Viaje> Viajes { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Transporte> Transportes { get; set; }

        public DbSet<TipoTransporte> TipoTransportes { get; set; }

        public DbSet<Tarjeta> Tarjetas { get; set; }

        public DbSet<Servicio> Servicios { get; set; }

        public DbSet<Reserva> Reservas { get; set; }

        public DbSet<Provincia> Provincias { get; set; }

        public DbSet<PasajeroViaje> PasajeroViajes { get; set; }

        public DbSet<Pasajero> Pasajeros { get; set; }

        public DbSet<Pasaje> Pasajes { get; set; }

        public DbSet<Pais> Paises { get; set; }

        public DbSet<Pago> Pagos { get; set; }

        public DbSet<MetodoPago> MetodoPagos { get; set; }

        public DbSet<Factura> Facturas { get; set; }

        public DbSet<Escala> Escalas { get; set; }

        public DbSet<CompaniaTransporte> CompaniaTransportes { get; set; }

        public DbSet<Ciudad> Ciudades  { get; set; }

        public DbSet<CaracteristicaTransporte> CaracteristicaTransportes { get; set; }

        public DbSet<Caracteristica> Caracteristicas { get; set; }

        public AgenciaViajesContext(DbContextOptions<AgenciaViajesContext> options)
        : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ViajeServicioConfig());

            modelBuilder.ApplyConfiguration(new ViajeCiudadConfig());

            modelBuilder.ApplyConfiguration(new ViajeConfig());

            modelBuilder.ApplyConfiguration(new UsuarioConfig());

            modelBuilder.ApplyConfiguration(new TransporteConfig());

            modelBuilder.ApplyConfiguration(new TipoTransporteConfig());

            modelBuilder.ApplyConfiguration(new TarjetaConfig());

            modelBuilder.ApplyConfiguration(new ServicioConfig());

            modelBuilder.ApplyConfiguration(new ReservaConfig());

            modelBuilder.ApplyConfiguration(new ProvinciaConfig());

            modelBuilder.ApplyConfiguration(new PasajeroViajeConfig());

            modelBuilder.ApplyConfiguration(new PasajeroConfig());

            modelBuilder.ApplyConfiguration(new PasajeConfig());

            modelBuilder.ApplyConfiguration(new PaisConfig());

            modelBuilder.ApplyConfiguration(new PagoConfig());

            modelBuilder.ApplyConfiguration(new MetodoPagoConfig());

            modelBuilder.ApplyConfiguration(new FacturaConfig());

            modelBuilder.ApplyConfiguration(new EscalaConfig());

            modelBuilder.ApplyConfiguration(new CompaniaTransporteConfig());

            modelBuilder.ApplyConfiguration(new CiudadConfig());

            modelBuilder.ApplyConfiguration(new CaracteristicaTransporteConfig());

            modelBuilder.ApplyConfiguration(new CaracteristicaConfig());
        }
    }

}
