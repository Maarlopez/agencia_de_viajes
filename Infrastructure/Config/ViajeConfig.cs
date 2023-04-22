using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Config
{
    public class ViajeConfig : IEntityTypeConfiguration<Viaje>
    {
        public void Configure(EntityTypeBuilder<Viaje> entityBuilder)
        {
            entityBuilder.ToTable("Viaje");
            entityBuilder.HasKey(e => e.ViajeId);

            entityBuilder.HasMany(m => m.ViajeCiudades)
            .WithOne(cm => cm.Viaje)
            .HasForeignKey(cm => cm.ViajeId);

            entityBuilder.HasMany(m => m.ViajeServicios)
            .WithOne(cm => cm.Viaje)
            .HasForeignKey(cm => cm.ViajeId);

            entityBuilder.HasMany(m => m.PasajeroViajes)
            .WithOne(cm => cm.Viaje)
            .HasForeignKey(cm => cm.ViajeId);

            entityBuilder.HasMany(m => m.Escalas)
            .WithOne(cm => cm.Viaje)
            .HasForeignKey(cm => cm.ViajeId);

            entityBuilder.HasMany(m => m.Reservas)
            .WithOne(cm => cm.Viaje)
            .HasForeignKey(cm => cm.ViajeId);
        }
    }
}
