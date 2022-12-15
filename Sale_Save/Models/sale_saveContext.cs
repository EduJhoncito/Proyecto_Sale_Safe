using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Sale_Save.Models
{
    public partial class sale_saveContext : DbContext
    {
        public sale_saveContext()
        {
        }

        public sale_saveContext(DbContextOptions<sale_saveContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categorium> Categoria { get; set; } = null!;
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Marca> Marcas { get; set; } = null!;
        public virtual DbSet<Producto> Productos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=sale_save;uid=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.24-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Categorium>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PRIMARY");

                entity.ToTable("categoria");

                entity.Property(e => e.IdCategoria)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("Id_Categoria");

                entity.Property(e => e.TipoCategoria)
                    .HasMaxLength(25)
                    .HasColumnName("Tipo_Categoria");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PRIMARY");

                entity.ToTable("cliente");

                entity.Property(e => e.IdCliente)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("Id_Cliente");

                entity.Property(e => e.Apellido).HasMaxLength(50);

                entity.Property(e => e.Direccion).HasMaxLength(180);

                entity.Property(e => e.Dni).HasColumnType("int(11)");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.Telefono).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Marca>(entity =>
            {
                entity.HasKey(e => e.IdMarca)
                    .HasName("PRIMARY");

                entity.ToTable("marca");

                entity.Property(e => e.IdMarca)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("Id_Marca");

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto)
                    .HasName("PRIMARY");

                entity.ToTable("productos");

                entity.HasIndex(e => e.IdCategoria, "Id_Categoria");

                entity.HasIndex(e => e.IdMarca, "Id_marca");

                entity.Property(e => e.IdProducto)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("Id_Producto");

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.Foto).HasMaxLength(200);

                entity.Property(e => e.IdCategoria)
                    .HasColumnType("int(11)")
                    .HasColumnName("Id_Categoria");

                entity.Property(e => e.IdMarca)
                    .HasColumnType("int(11)")
                    .HasColumnName("Id_marca");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.Stock).HasColumnType("int(11)");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("productos_ibfk_1");

                entity.HasOne(d => d.IdMarcaNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.IdMarca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("productos_ibfk_2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
