using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Config
{
    public class PaisConfig : IEntityTypeConfiguration<Pais>
    {
        public void Configure(EntityTypeBuilder<Pais> entityBuilder)
        {
            entityBuilder.ToTable("Pais");
            entityBuilder.HasKey(e => e.PaisId);

            entityBuilder.HasMany(m => m.Provincias)
            .WithOne(cm => cm.Pais)
            .HasForeignKey(cm => cm.PaisId);
        }
    }
}
