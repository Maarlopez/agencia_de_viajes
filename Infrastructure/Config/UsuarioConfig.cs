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
    public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> entityBuilder)
        {
            entityBuilder.ToTable("Usuario");
            entityBuilder.HasKey(e => e.UsuarioId);

            entityBuilder.HasMany(m => m.Reservas)
            .WithOne(cm => cm.Usuario)
            .HasForeignKey(cm => cm.UsuarioId);

            entityBuilder.HasMany(m => m.Tarjetas)
            .WithOne(cm => cm.Usuario)
            .HasForeignKey(cm => cm.UsuarioId);
        }
    }
}
