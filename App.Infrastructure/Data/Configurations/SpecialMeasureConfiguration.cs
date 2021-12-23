using App.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Infrastructure.Data.Configurations
{
    public class SpecialMeasureConfiguration : IEntityTypeConfiguration<SpecialMeasureEntity>
    {
        public void Configure(EntityTypeBuilder<SpecialMeasureEntity> builder)
        {
            builder.ToTable("Medida_especial");
            builder.HasKey(e => e.IdMessage);

            builder.ToTable("Medida_especial", "mensajes_suscripciones");

            builder.Property(e => e.IdMessage)
            .HasColumnName("id_mensaje");

            builder.Property(e => e.SenderEmail)
                .IsRequired()
                .HasColumnName("email_remitente")
                .HasMaxLength(100)
                .IsFixedLength();

            builder.Property(e => e.Status)
                .HasColumnName("estado")
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

            builder.Property(e => e.MessageTime)
                .HasColumnName("fecha_mensaje")
                .HasColumnType("datetime");

            builder.Property(e => e.SenderMessage)
                .IsRequired()
                .HasColumnName("mensaje_remitente")
                .HasMaxLength(1000)
                .IsFixedLength();

            builder.Property(e => e.SenderName)
                .IsRequired()
                .HasColumnName("nombre_remitente")
                .HasMaxLength(100)
                .IsFixedLength();
        }
    }
}
