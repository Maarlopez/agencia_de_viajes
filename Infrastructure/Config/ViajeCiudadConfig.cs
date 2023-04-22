using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config
{
    public class ViajeCiudadConfig : IEntityTypeConfiguration<ViajeCiudad>
    {
        public void Configure(EntityTypeBuilder<ViajeCiudad> entityBuilder)
        {
            entityBuilder.ToTable("ViajeCiudad");
            entityBuilder.HasKey(e => e.ViajeCiudadId);

            entityBuilder.Property(m => m.ViajeCiudadId).ValueGeneratedOnAdd();

        }
    }
}
