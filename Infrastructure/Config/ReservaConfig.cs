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
    public class ReservaConfig : IEntityTypeConfiguration<Reserva>
    {
        public void Configure(EntityTypeBuilder<Reserva> entityBuilder)
        {
            entityBuilder.ToTable("Reserva");
            entityBuilder.HasKey(e => e.ReservaId);

            entityBuilder.HasMany(m => m.Pasajes)
            .WithOne(cm => cm.Reserva)
            .HasForeignKey(cm => cm.ReservaId);
        }
    }
}
