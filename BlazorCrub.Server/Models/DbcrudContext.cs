using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrub.Server.Models;

public partial class DbcrudContext : DbContext
{
    public DbcrudContext()
    {
    }

    public DbcrudContext(DbContextOptions<DbcrudContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Personaje> Personajes { get; set; }

    public virtual DbSet<Serie> Series { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Personaje>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Personaj__3214EC076FB1FF3C");

            entity.ToTable("Personaje");

            entity.Property(e => e.Apodo).HasMaxLength(255);
            entity.Property(e => e.FotoUrl).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(255);
            entity.Property(e => e.PoderCaracteristico).HasMaxLength(255);
            entity.Property(e => e.Raza).HasMaxLength(100);

            entity.HasOne(d => d.Serie).WithMany(p => p.Personajes)
                .HasForeignKey(d => d.SerieId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Personaje__Serie__4BAC3F29");
        });

        modelBuilder.Entity<Serie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Serie__3214EC076371E25D");

            entity.ToTable("Serie");

            entity.Property(e => e.FotoUrl).HasMaxLength(255);
            entity.Property(e => e.Idioma).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(255);
            entity.Property(e => e.Pais).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
