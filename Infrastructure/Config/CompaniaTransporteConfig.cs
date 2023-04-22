using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config
{
    public class CompaniaTransporteConfig : IEntityTypeConfiguration<CompaniaTransporte>
    {
        public void Configure(EntityTypeBuilder<CompaniaTransporte> entityBuilder)
        {
            entityBuilder.ToTable("CompaniaTransporte");
            entityBuilder.HasKey(e => e.CompaniaTransporteId);

            entityBuilder.HasMany(m => m.Transportes)
            .WithOne(cm => cm.CompaniaTransporte)
            .HasForeignKey(cm => cm.CompaniaTransporteId);
        }
    }
}
