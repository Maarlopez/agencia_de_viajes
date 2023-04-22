using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config
{
    public class ViajeServicioConfig : IEntityTypeConfiguration<ViajeServicio>
    {
        public void Configure(EntityTypeBuilder<ViajeServicio> entityBuilder)
        {
            entityBuilder.ToTable("ViajeServicio");
            entityBuilder.HasKey(e => e.ViajeServicioId);

            entityBuilder.Property(m => m.ViajeServicioId).ValueGeneratedOnAdd();

        }
    }
}
