using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config
{
    public class EscalaConfig : IEntityTypeConfiguration<Escala>
    {
        public void Configure(EntityTypeBuilder<Escala> entityBuilder)
        {
            entityBuilder.ToTable("Escala");
            entityBuilder.HasKey(e => e.EscalaId);
        }
    }
}
