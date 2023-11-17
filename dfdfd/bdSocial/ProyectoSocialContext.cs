using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ProyectoSocial.bdSocial;

namespace dfdfd.bdSocial;

public partial class ProyectoSocialContext : DbContext
{
    public ProyectoSocialContext()
    {
    }

    public ProyectoSocialContext(DbContextOptions<ProyectoSocialContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DatosAlumno> DatosAlumnos { get; set; }
    public virtual DbSet<horasSociales>horasSociales { get; set; }
    public virtual DbSet<Eventos> Eventos { get; set; }
    public virtual DbSet<tbDatosRegistro> tbDatosRegistro { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlServer("Data Source= DESKTOP-IJ4S2TJ\\SQLEXPRESS;Initial Catalog=proyectoSocial;Integrated Security=True; Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DatosAlumno>(entity =>
        {
            entity.HasKey(e => e.Carnet).HasName("PK__DatosAlu__4CDEAA6FF685EF26");

            entity.Property(e => e.Carnet)
                .ValueGeneratedNever()
                .HasColumnName("carnet");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("apellidos");
            entity.Property(e => e.Contraseña)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("contraseña");
            entity.Property(e => e.Correo)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.Encargado)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("encargado");
            entity.Property(e => e.Grupo)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("grupo");
            entity.Property(e => e.NivelUsuario).HasColumnName("nivelUsuario");
            entity.Property(e => e.Nombres)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nombres");
            entity.Property(e => e.TipoEstudio)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tipoEstudio");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
