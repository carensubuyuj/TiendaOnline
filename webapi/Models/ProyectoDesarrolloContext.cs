using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace webapi.Models;

public partial class ProyectoDesarrolloContext : DbContext
{
    public ProyectoDesarrolloContext()
    {
    }

    public ProyectoDesarrolloContext(DbContextOptions<ProyectoDesarrolloContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<EntregaPaquete> EntregaPaquetes { get; set; }

    public virtual DbSet<NotasCredito> NotasCreditos { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Ventum> Venta { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\ROSMERY;Database=ProyectoDesarrollo;User Id=sa;Password=rosmery;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Idcliente).HasName("PK__Cliente__9B8553FCEFB11E06");

            entity.ToTable("Cliente");

            entity.Property(e => e.Idcliente)
                .ValueGeneratedNever()
                .HasColumnName("IDCliente");
            entity.Property(e => e.ApellidosCliente).HasMaxLength(1000);
            entity.Property(e => e.CategoriaCliente).HasMaxLength(50);
            entity.Property(e => e.DireccionCliente).HasMaxLength(100);
            entity.Property(e => e.EstadoCliente).HasMaxLength(20);
            entity.Property(e => e.Nit)
                .HasMaxLength(15)
                .HasColumnName("NIT");
            entity.Property(e => e.NombresCliente).HasMaxLength(100);
        });

        modelBuilder.Entity<EntregaPaquete>(entity =>
        {
            entity.HasKey(e => e.Identrega).HasName("PK__EntregaP__9670127CC951F710");

            entity.Property(e => e.Identrega)
                .ValueGeneratedNever()
                .HasColumnName("IDEntrega");
            entity.Property(e => e.EstadoEntrega).HasMaxLength(50);
            entity.Property(e => e.FechaEntrega).HasColumnType("datetime");
            entity.Property(e => e.Idcliente).HasColumnName("IDCliente");
        });

        modelBuilder.Entity<NotasCredito>(entity =>
        {
            entity.HasKey(e => e.IdnotaCredito).HasName("PK__NotasCre__389C5B71FEF598FC");

            entity.ToTable("NotasCredito");

            entity.Property(e => e.IdnotaCredito)
                .ValueGeneratedNever()
                .HasColumnName("IDNotaCredito");
            entity.Property(e => e.Idventa).HasColumnName("IDVenta");
            entity.Property(e => e.Monto).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Motivo).HasMaxLength(100);
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Idproducto).HasName("PK__Producto__ABDAF2B4E2003CE6");

            entity.ToTable("Producto");

            entity.Property(e => e.Idproducto)
                .ValueGeneratedNever()
                .HasColumnName("IDProducto");
            entity.Property(e => e.Descripcion).HasMaxLength(100);
            entity.Property(e => e.FechaVencimiento).HasMaxLength(100);
            entity.Property(e => e.UbicacionFisica).HasMaxLength(100);
        });

        modelBuilder.Entity<Ventum>(entity =>
        {
            entity.HasKey(e => e.Idventa).HasName("PK__Venta__27134B8253F07A07");

            entity.Property(e => e.Idventa)
                .ValueGeneratedNever()
                .HasColumnName("IDVenta");
            entity.Property(e => e.FechaVenta).HasColumnType("datetime");
            entity.Property(e => e.Idcliente).HasColumnName("IDCliente");
            entity.Property(e => e.Idproducto).HasColumnName("IDProducto");
            entity.Property(e => e.PrecioUnitario).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TipoVenta).HasMaxLength(20);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
