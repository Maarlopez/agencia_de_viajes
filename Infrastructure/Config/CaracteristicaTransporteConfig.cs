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
    public class CaracteristicaTransporteConfig : IEntityTypeConfiguration<CaracteristicaTransporte>
    {
        public void Configure(EntityTypeBuilder<CaracteristicaTransporte> entityBuilder)
        {
            entityBuilder.ToTable("CaracteristicaTransporte");
            entityBuilder.HasKey(e => e.CaracteristicaTransporteId);
        }
    }
}
