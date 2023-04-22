using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config
{
    public class PasajeroViajeConfig : IEntityTypeConfiguration<PasajeroViaje>
    {
        public void Configure(EntityTypeBuilder<PasajeroViaje> entityBuilder)
        {
            entityBuilder.ToTable("PasajeroViaje");
            entityBuilder.HasKey(e => e.PasajeroViajeId);
        }
    }
}
