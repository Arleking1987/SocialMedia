using System;
using App.Infrastructure.Data.Configurations;
using App.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace App.Infrastructure.Data
{
    public partial class Estado_PedidosContext : DbContext
    {
        public Estado_PedidosContext()
        {
        }

        public Estado_PedidosContext(DbContextOptions<Estado_PedidosContext> options)
            : base(options)
        {
        }

       
        public virtual DbSet<SpecialMeasureEntity> SpecialMeasures { get; set; }      
        public virtual DbSet<NewsletterSubscriptionEntity> NewsletterSubscriptions { get; set; }
     
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {           
            modelBuilder.ApplyConfiguration(new SpecialMeasureConfiguration());         
            modelBuilder.ApplyConfiguration(new NewsletterSubscriptionConfiguration());         
        }

       
    }
}
