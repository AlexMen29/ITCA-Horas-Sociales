using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProyectoSocial.Contexto;

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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source = DESKTOP-E4D98NB\\SQLEXPRESS; Initial Catalog = proyectoSocial; Integrated Security = True; Encrypt = False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DatosAlumno>(entity =>
        {
            entity.HasKey(e => e.Carnet).HasName("PK__DatosAlu__4CDEAA6FE63AB854");

            entity.Property(e => e.Carnet)
                .HasMaxLength(10)
                .IsUnicode(false)
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
