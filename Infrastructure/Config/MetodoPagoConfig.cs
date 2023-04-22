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
    public class MetodoPagoConfig : IEntityTypeConfiguration<MetodoPago>
    {
        public void Configure(EntityTypeBuilder<MetodoPago> entityBuilder)
        {
            entityBuilder.ToTable("MetodoPago");
            entityBuilder.HasKey(e => e.MetodoPagoId);

            entityBuilder.HasMany(m => m.Pagos)
            .WithOne(cm => cm.MetodoPago)
            .HasForeignKey(cm => cm.MetodoPagoId);
        }
    }
}
