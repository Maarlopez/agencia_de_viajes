using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config
{
    public class TarjetaConfig : IEntityTypeConfiguration<Tarjeta>
    {
        public void Configure(EntityTypeBuilder<Tarjeta> entityBuilder)
        {
            entityBuilder.ToTable("Tarjeta");
            entityBuilder.HasKey(e => e.TarjetaId);
        }
    }
}
