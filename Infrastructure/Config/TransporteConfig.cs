﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config
{
    public class TransporteConfig : IEntityTypeConfiguration<Transporte>
    {
        public void Configure(EntityTypeBuilder<Transporte> entityBuilder)
        {
            entityBuilder.ToTable("Transporte");
            entityBuilder.HasKey(e => e.TransporteId);

            entityBuilder.HasMany(m => m.Viajes)
            .WithOne(cm => cm.Transporte)
            .HasForeignKey(cm => cm.TransporteId);

            entityBuilder.HasMany(m => m.CaracteristicasTransportes)
            .WithOne(cm => cm.Transporte)
            .HasForeignKey(cm => cm.TransporteId);
        }
    }
}
