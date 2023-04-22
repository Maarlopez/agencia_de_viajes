using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config
{
    public class TipoTransporteConfig : IEntityTypeConfiguration<TipoTransporte>
    {
        public void Configure(EntityTypeBuilder<TipoTransporte> entityBuilder)
        {
            entityBuilder.ToTable("TipoTransporte");
            entityBuilder.HasKey(e => e.TipoTransporteId);

            entityBuilder.HasMany(m => m.Transportes)
            .WithOne(cm => cm.TipoTransporte)
            .HasForeignKey(cm => cm.TipoTransporteId);

        }
    }
}
