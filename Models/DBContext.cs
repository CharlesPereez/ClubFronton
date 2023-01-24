using System;
using System.Collections.Generic;
using CRUDPersonas.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CRUDPersonas.Models
{
    public partial class DBContext : IdentityDbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cancha>(entity =>
            {
                entity.ToTable("cancha");

                entity.Property(e => e.CanchaId).HasColumnName("cancha_id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.EstadoCancha).HasColumnName("estado_cancha");

                entity.Property(e => e.HorarioId).HasColumnName("horario_id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.Horario)
                    .WithMany(p => p.Canchas)
                    .HasForeignKey(d => d.HorarioId)
                    .HasConstraintName("fk_cancha_horario");
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.CategoriaId)
                    .HasName("PK__categori__DB875A4FA9C4CE7B");

                entity.ToTable("categoria");

                entity.Property(e => e.CategoriaId).HasColumnName("categoria_id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("cliente");

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.PersonaId).HasColumnName("persona_id");

                entity.Property(e => e.ReservaId).HasColumnName("reserva_id");

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.PersonaId)
                    .HasConstraintName("fk_cliente_persona");

                entity.HasOne(d => d.Reserva)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.ReservaId)
                    .HasConstraintName("fk_cliente_reserva");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.ToTable("empleado");

                entity.Property(e => e.EmpleadoId).HasColumnName("empleado_id");

                entity.Property(e => e.Clave)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("clave");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.PersonaId).HasColumnName("persona_id");

                entity.Property(e => e.RolId).HasColumnName("rol_id");

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.PersonaId)
                    .HasConstraintName("fk_empleado_persona");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.RolId)
                    .HasConstraintName("FK__empleado__rol_id__5070F446");
            });

            modelBuilder.Entity<EstadoHorario>(entity =>
            {
                entity.ToTable("estado_horario");

                entity.Property(e => e.EstadoHorarioId).HasColumnName("estado_horario_id");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipo");
            });

            modelBuilder.Entity<EstadoReserva>(entity =>
            {
                entity.ToTable("estado_reserva");

                entity.Property(e => e.EstadoReservaId).HasColumnName("estado_reserva_id");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipo");
            });

            modelBuilder.Entity<Horario>(entity =>
            {
                entity.ToTable("horario");

                entity.Property(e => e.HorarioId).HasColumnName("horario_id");

                entity.Property(e => e.EstadoHorarioId).HasColumnName("estado_horario_id");

                entity.Property(e => e.HoraFin).HasColumnName("hora_fin");

                entity.Property(e => e.HoraInicio).HasColumnName("hora_inicio");

                entity.Property(e => e.ReservaId).HasColumnName("reserva_id");

                entity.HasOne(d => d.EstadoHorario)
                    .WithMany(p => p.Horarios)
                    .HasForeignKey(d => d.EstadoHorarioId)
                    .HasConstraintName("fk_horario_estado_horario");

                entity.HasOne(d => d.Reserva)
                    .WithMany(p => p.Horarios)
                    .HasForeignKey(d => d.ReservaId)
                    .HasConstraintName("fk_horario_reserva");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.ToTable("persona");

                entity.Property(e => e.PersonaId).HasColumnName("persona_id");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellidos");

                entity.Property(e => e.CiPersona)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ci_persona");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("fecha_nacimiento");

                entity.Property(e => e.Genero)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("genero");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombres");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.ToTable("producto");

                entity.Property(e => e.ProductoId).HasColumnName("producto_id");

                entity.Property(e => e.CategoriaId).HasColumnName("categoria_id");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Precio)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("precio");

                entity.Property(e => e.ProveedorId).HasColumnName("proveedor_id");

                entity.Property(e => e.Stock).HasColumnName("stock");

                entity.HasOne(d => d.Categoria)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.CategoriaId)
                    .HasConstraintName("fk_producto_categoria");

                entity.HasOne(d => d.Proveedor)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.ProveedorId)
                    .HasConstraintName("fk_producto_proveedor");
            });

            modelBuilder.Entity<Proveedor>(entity =>
            {
                entity.ToTable("proveedor");

                entity.Property(e => e.ProveedorId).HasColumnName("proveedor_id");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.PaginaWeb)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pagina_web");

                entity.Property(e => e.Teñlefono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("teñlefono");
            });

            modelBuilder.Entity<Reserva>(entity =>
            {
                entity.ToTable("reserva");

                entity.Property(e => e.ReservaId).HasColumnName("reserva_id");

                entity.Property(e => e.Duracion)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("duracion");

                entity.Property(e => e.EstadoReservaId).HasColumnName("estado_reserva_id");

                entity.Property(e => e.FechaReserva)
                    .HasColumnType("date")
                    .HasColumnName("fecha_reserva");

                entity.Property(e => e.PersonaId).HasColumnName("persona_id");

                entity.HasOne(d => d.EstadoReserva)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.EstadoReservaId)
                    .HasConstraintName("fk_reserva_estado_reserva");

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.PersonaId)
                    .HasConstraintName("fk_reserva_persona");
            });

            modelBuilder.Entity<ReservaVenta>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("reserva_venta");

                entity.Property(e => e.ReservaId).HasColumnName("reserva_id");

                entity.Property(e => e.VentaId).HasColumnName("venta_id");

                entity.HasOne(d => d.Reserva)
                    .WithMany()
                    .HasForeignKey(d => d.ReservaId)
                    .HasConstraintName("fk_reserva_venta_reserva");

                entity.HasOne(d => d.Venta)
                    .WithMany()
                    .HasForeignKey(d => d.VentaId)
                    .HasConstraintName("fk_reserva_venta_venta");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.ToTable("rol");

                entity.Property(e => e.RolId).HasColumnName("rol_id");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasColumnName("fecha_registro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<VentaProducto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("venta_producto");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.MontoTotal)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("monto_total");

                entity.Property(e => e.Precio)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("precio");

                entity.Property(e => e.ProductoId).HasColumnName("producto_id");

                entity.Property(e => e.VentaId).HasColumnName("venta_id");

                entity.HasOne(d => d.Producto)
                    .WithMany()
                    .HasForeignKey(d => d.ProductoId)
                    .HasConstraintName("FK__venta_pro__produ__6EF57B66");

                entity.HasOne(d => d.Venta)
                    .WithMany()
                    .HasForeignKey(d => d.VentaId)
                    .HasConstraintName("FK__venta_pro__venta__6E01572D");
            });

            modelBuilder.Entity<Venta>(entity =>
            {
                entity.HasKey(e => e.VentaId)
                    .HasName("PK__venta__B135080966F135F5");

                entity.ToTable("venta");

                entity.Property(e => e.VentaId).HasColumnName("venta_id");

                entity.Property(e => e.Descuento)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("descuento");

                entity.Property(e => e.FechaDate)
                    .HasColumnType("date")
                    .HasColumnName("fecha_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MontoFinal)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("monto_final");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        public virtual DbSet<Cancha> Canchas { get; set; } = null!;
        public virtual DbSet<Categoria> Categoria { get; set; } = null!;
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Empleado> Empleados { get; set; } = null!;
        public virtual DbSet<EstadoHorario> EstadoHorarios { get; set; } = null!;
        public virtual DbSet<EstadoReserva> EstadoReservas { get; set; } = null!;
        public virtual DbSet<Horario> Horarios { get; set; } = null!;
        public virtual DbSet<Persona> Personas { get; set; } = null!;
        public virtual DbSet<Producto> Productos { get; set; } = null!;
        public virtual DbSet<Proveedor> Proveedors { get; set; } = null!;
        public virtual DbSet<Reserva> Reservas { get; set; } = null!;
        public virtual DbSet<ReservaVenta> ReservaVenta { get; set; } = null!;
        public virtual DbSet<Rol> Rols { get; set; } = null!;
        public virtual DbSet<VentaProducto> VentaProductos { get; set; } = null!;
        public virtual DbSet<Venta> Venta { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){ }    


        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
