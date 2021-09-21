﻿using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace APPO_2._0_.Models
{
    public partial class APPO20Context : DbContext
    {
        public APPO20Context()
        {
        }

        public APPO20Context(DbContextOptions<APPO20Context> options)
            : base(options)
        {
        }

        public virtual DbSet<ComprasMoneda> ComprasMonedas { get; set; }
        public virtual DbSet<Cuenta> Cuentas { get; set; }
        public virtual DbSet<IngresosDinero> IngresosDineros { get; set; }
        public virtual DbSet<Inversione> Inversiones { get; set; }
        public virtual DbSet<PagosServicio> PagosServicios { get; set; }
        public virtual DbSet<RetirosDinero> RetirosDineros { get; set; }
        public virtual DbSet<Servicio> Servicios { get; set; }
        public virtual DbSet<TiposCuenta> TiposCuentas { get; set; }
        public virtual DbSet<Transferencia> Transferencias { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<VentasMoneda> VentasMonedas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-4BB8CTC\\SQLEXPRESS;Database=APPO 2.0;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<ComprasMoneda>(entity =>
            {
                entity.HasKey(e => e.NroCompCompra)
                    .HasName("PK_ComprasCripto");

                entity.Property(e => e.NroCompCompra).HasColumnName("nro_comp_compra");

                entity.Property(e => e.CvuCompra).HasColumnName("CVU_compra");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("monto");

                entity.Property(e => e.NombreCripto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_cripto");

                entity.HasOne(d => d.CvuCompraNavigation)
                    .WithMany(p => p.ComprasMoneda)
                    .HasForeignKey(d => d.CvuCompra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComprasMonedas_Cuentas");
            });

            modelBuilder.Entity<Cuenta>(entity =>
            {
                entity.HasKey(e => e.Cvu);

                entity.Property(e => e.Cvu).HasColumnName("CVU");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("alias");

                entity.Property(e => e.IdTipoCuenta).HasColumnName("id_tipo_cuenta");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.SaldoActual)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("saldo_actual");

                entity.HasOne(d => d.IdTipoCuentaNavigation)
                    .WithMany(p => p.Cuenta)
                    .HasForeignKey(d => d.IdTipoCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cuentas_TipoCuentas");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Cuenta)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cuentas_Usuario");
            });

            modelBuilder.Entity<IngresosDinero>(entity =>
            {
                entity.HasKey(e => e.IdDeposito);

                entity.ToTable("IngresosDinero");

                entity.Property(e => e.IdDeposito).HasColumnName("id_deposito");

                entity.Property(e => e.CodSeguridad).HasColumnName("cod_seguridad");

                entity.Property(e => e.CvuDeposito).HasColumnName("CVU_deposito");

                entity.Property(e => e.FechaVenc)
                    .HasColumnType("date")
                    .HasColumnName("fecha_venc");

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("monto");

                entity.Property(e => e.NombreDeposito)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_deposito");

                entity.Property(e => e.NombreTitular)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_titular");

                entity.Property(e => e.NroTarjeta)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nro_tarjeta");

                entity.HasOne(d => d.CvuDepositoNavigation)
                    .WithMany(p => p.IngresosDineros)
                    .HasForeignKey(d => d.CvuDeposito)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IngresosDinero_Cuentas");
            });

            modelBuilder.Entity<Inversione>(entity =>
            {
                entity.HasKey(e => e.IdInversion);

                entity.Property(e => e.IdInversion).HasColumnName("id_inversion");

                entity.Property(e => e.CvuInversion).HasColumnName("CVU_inversion");

                entity.Property(e => e.FechaFin)
                    .HasColumnType("date")
                    .HasColumnName("fecha_fin");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("date")
                    .HasColumnName("fecha_inicio");

                entity.Property(e => e.MontoInversion)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("monto_inversion");

                entity.HasOne(d => d.CvuInversionNavigation)
                    .WithMany(p => p.Inversiones)
                    .HasForeignKey(d => d.CvuInversion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inversiones_Cuentas");
            });

            modelBuilder.Entity<PagosServicio>(entity =>
            {
                entity.HasKey(e => e.NroComprobante);

                entity.ToTable("PagosServicio");

                entity.Property(e => e.NroComprobante).HasColumnName("nro_comprobante");

                entity.Property(e => e.CvuPago).HasColumnName("CVU_pago");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");

                entity.Property(e => e.IdServicio).HasColumnName("id_servicio");

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("monto");

                entity.Property(e => e.NombreFactura)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_factura");

                entity.Property(e => e.NroFactura).HasColumnName("nro_factura");

                entity.HasOne(d => d.CvuPagoNavigation)
                    .WithMany(p => p.PagosServicios)
                    .HasForeignKey(d => d.CvuPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PagosServicio_Cuentas");

                entity.HasOne(d => d.IdServicioNavigation)
                    .WithMany(p => p.PagosServicios)
                    .HasForeignKey(d => d.IdServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PagosServicio_Servicios");
            });

            modelBuilder.Entity<RetirosDinero>(entity =>
            {
                entity.HasKey(e => e.IdRetiro);

                entity.ToTable("RetirosDinero");

                entity.Property(e => e.IdRetiro).HasColumnName("id_retiro");

                entity.Property(e => e.CvuRetiro).HasColumnName("CVU_retiro");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("monto");

                entity.HasOne(d => d.CvuRetiroNavigation)
                    .WithMany(p => p.RetirosDineros)
                    .HasForeignKey(d => d.CvuRetiro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RetirosDinero_Cuentas");
            });

            modelBuilder.Entity<Servicio>(entity =>
            {
                entity.HasKey(e => e.IdServicio);

                entity.Property(e => e.IdServicio).HasColumnName("id_servicio");

                entity.Property(e => e.NombreServicio)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_servicio");
            });

            modelBuilder.Entity<TiposCuenta>(entity =>
            {
                entity.HasKey(e => e.IdTipoCuenta);

                entity.Property(e => e.IdTipoCuenta).HasColumnName("id_tipo_cuenta");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Transferencia>(entity =>
            {
                entity.HasKey(e => e.NroTransferencia);

                entity.Property(e => e.NroTransferencia).HasColumnName("nro_transferencia");

                entity.Property(e => e.CvuDestino).HasColumnName("CVU_destino");

                entity.Property(e => e.CvuOrigen).HasColumnName("CVU_origen");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("monto");

                entity.Property(e => e.Referencia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("referencia");

                entity.HasOne(d => d.CvuDestinoNavigation)
                    .WithMany(p => p.TransferenciaCvuDestinoNavigations)
                    .HasForeignKey(d => d.CvuDestino)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transferencias_Cuentas_Destino");

                entity.HasOne(d => d.CvuOrigenNavigation)
                    .WithMany(p => p.TransferenciaCvuOrigenNavigations)
                    .HasForeignKey(d => d.CvuOrigen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transferencias_Cuentas_Origen");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK_Usuarios_1");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.Dni).HasColumnName("dni");

                entity.Property(e => e.FotoDniDorso).HasColumnName("foto_dni_dorso");

                entity.Property(e => e.FotoDniFrente).HasColumnName("foto_dni_frente");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("password");
            });

            modelBuilder.Entity<VentasMoneda>(entity =>
            {
                entity.HasKey(e => e.NroCompVentas)
                    .HasName("PK_VentasCripto");

                entity.Property(e => e.NroCompVentas).HasColumnName("nro_comp_ventas");

                entity.Property(e => e.CvuVenta).HasColumnName("CVU_venta");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("monto");

                entity.HasOne(d => d.CvuVentaNavigation)
                    .WithMany(p => p.VentasMoneda)
                    .HasForeignKey(d => d.CvuVenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VentasMonedas_Cuentas");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
