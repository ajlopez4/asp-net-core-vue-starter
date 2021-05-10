using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AspNetCoreVueStarter.Models
{
    public partial class coreDBContext : IdentityDbContext
    {
        public coreDBContext()
        {
        }

        public coreDBContext(DbContextOptions<coreDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Photos> Photos { get; set; }
        public virtual DbSet<Todo> Todo { get; set; }
        public virtual DbSet<X_WeatherForecasts> WeatherForecasts { get; set; }
        public virtual DbSet<WeatherSummaries> WeatherSummaries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=sqlservertest2db.database.windows.net;Initial Catalog=coreDB;User ID=ajlopez4;Password=Anx310zy!0413;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Photos>(entity =>
            {
                entity.Property(e => e.ImageName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PhotoTitle)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Todo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Done).HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsPriority).HasColumnName("isPriority");
            });

            modelBuilder.Entity<X_WeatherForecasts>(entity =>
            {
                entity.Property(e => e.DateFormatted).HasColumnType("datetime");

                entity.Property(e => e.Summary)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<WeatherSummaries>(entity =>
            {
                entity.Property(e => e.Summary)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
