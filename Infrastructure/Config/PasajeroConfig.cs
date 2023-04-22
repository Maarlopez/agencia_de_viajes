using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config
{
    public class PasajeroConfig : IEntityTypeConfiguration<Pasajero>
    {
        public void Configure(EntityTypeBuilder<Pasajero> entityBuilder)
        {
            entityBuilder.ToTable("Pasajero");
            entityBuilder.HasKey(e => e.PasajeroId);

            entityBuilder.HasMany(m => m.PasajerosViajes)
            .WithOne(cm => cm.Pasajero)
            .HasForeignKey(cm => cm.PasajeroId);
        }
    }
}
