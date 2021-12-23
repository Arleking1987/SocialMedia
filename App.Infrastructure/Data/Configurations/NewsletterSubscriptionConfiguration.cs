using App.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Infrastructure.Data.Configurations
{
   public class NewsletterSubscriptionConfiguration : IEntityTypeConfiguration<NewsletterSubscriptionEntity>
    {
        public void Configure(EntityTypeBuilder<NewsletterSubscriptionEntity> builder)
        {
            builder.ToTable("suscripcion_boletin", "mensajes_suscripciones");

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.Coupon)
                .HasColumnName("cupon")
                .HasMaxLength(20)
                .IsFixedLength();

            builder.Property(e => e.Email)
                .IsRequired()
                .HasColumnName("email")
                .HasMaxLength(100)
                .IsFixedLength();

            builder.Property(e => e.CouponStatus)
                .HasColumnName("estado_cupon")
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        }
   }
}
