using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config
{
    public class CiudadConfig : IEntityTypeConfiguration<Ciudad>
    {
        public void Configure(EntityTypeBuilder<Ciudad> entityBuilder)
        {
            entityBuilder.ToTable("Ciudad");
            entityBuilder.HasKey(e => e.CiudadId);

            entityBuilder.HasMany(m => m.ViajeCiudades)
            .WithOne(cm => cm.Ciudad)
            .HasForeignKey(cm => cm.CiudadId);
        }
    }
}
