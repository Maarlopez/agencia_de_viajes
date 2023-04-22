﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Config
{
    public class PasajeConfig : IEntityTypeConfiguration<Pasaje>
    {
        public void Configure(EntityTypeBuilder<Pasaje> entityBuilder)
        {
            entityBuilder.ToTable("Pasaje");
            entityBuilder.HasKey(e => e.PasajeId);
        }
    }
}