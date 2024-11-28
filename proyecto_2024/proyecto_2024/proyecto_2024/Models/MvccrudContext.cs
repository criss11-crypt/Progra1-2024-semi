using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace proyecto_2024.Models;

public partial class MvccrudContext : DbContext
{
    public MvccrudContext()
    {
    }


    public MvccrudContext(DbContextOptions<MvccrudContext> options)
        : base(options)
    {
    }
    public virtual DbSet<CruzRoja> CruzRoja { get; set; }

    public virtual DbSet<Hospital> Hospitals { get; set; }
    public virtual DbSet<Policia> Policias { get; set; }
    public virtual DbSet<Bomberos> Bomberos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=MVCCRUD; integrated security=true;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Hospital>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Hospital__3213E83F80B6F1D3");

            entity.ToTable("Hospital");

            entity.HasIndex(e => e.Dui, "UQ__Hospital__C0317D91D4A3785F").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Direccion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Dui)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });
        modelBuilder.Entity<CruzRoja>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CruzRoja__3213E83F5A2F1B8D");

            entity.ToTable("CruzRoja");

            entity.HasIndex(e => e.Dui, "UQ__CruzRoja__C0317D91223A4E5B").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Direccion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Dui)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionCaso)
                .HasMaxLength(500)
                .IsUnicode(false);
        });
        modelBuilder.Entity<Policia>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Policia__3213E83F80B6F1D3");

            entity.ToTable("Policia");

            entity.HasIndex(e => e.Dui, "UQ__Policia__C0317D91D4A3785F").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Direccion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Dui)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionCaso)
                .HasMaxLength(500)
                .IsUnicode(false);

        });
        modelBuilder.Entity<Bomberos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Bomberos__3213E83F5A2F1B8D");

            entity.ToTable("Bomberos");

            entity.HasIndex(e => e.Dui, "UQ__Bomberos__C0317D91223A4E5B").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Direccion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Dui)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionCaso)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
