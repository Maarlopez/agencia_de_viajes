using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config
{
    public class CaracteristicaConfig : IEntityTypeConfiguration<Caracteristica>
    {
        public void Configure(EntityTypeBuilder<Caracteristica> entityBuilder)
        {
            entityBuilder.ToTable("Caracteristica");
            entityBuilder.HasKey(e => e.CaracteristicaId);

            entityBuilder.HasMany(m => m.CaracteristicasTransportes)
            .WithOne(cm => cm.Caracteristica)
            .HasForeignKey(cm => cm.CaracteristicaId);
        }
    }
}
