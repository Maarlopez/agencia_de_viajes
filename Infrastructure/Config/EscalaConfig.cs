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
    public class EscalaConfig : IEntityTypeConfiguration<Escala>
    {
        public void Configure(EntityTypeBuilder<Escala> entityBuilder)
        {
            entityBuilder.ToTable("Escala");
            entityBuilder.HasKey(e => e.EscalaId);
        }
    }
}
