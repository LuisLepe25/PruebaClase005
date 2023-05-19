﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PruebaClase005.Models.dbModels;

#nullable disable

namespace PruebaClase005.Migrations
{
    [DbContext(typeof(TiendaPruebaContext))]
    [Migration("20230512025413_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("PruebaClase005.Models.dbModels.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("PruebaClase005.Models.dbModels.Carrito", b =>
                {
                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<int>("IdProducto")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaAñadido")
                        .HasColumnType("datetime");

                    b.HasKey("IdUsuario", "IdProducto");

                    b.HasIndex("IdProducto");

                    b.ToTable("Carrito");
                });

            modelBuilder.Entity("PruebaClase005.Models.dbModels.Deseado", b =>
                {
                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<int>("IdProducto")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaAñadido")
                        .HasColumnType("datetime");

                    b.HasKey("IdUsuario", "IdProducto");

                    b.HasIndex("IdProducto");

                    b.ToTable("Deseados");
                });

            modelBuilder.Entity("PruebaClase005.Models.dbModels.Marca", b =>
                {
                    b.Property<int>("IdMarca")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMarca"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Imagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdMarca");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("PruebaClase005.Models.dbModels.Producto", b =>
                {
                    b.Property<int>("IdProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProducto"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("DescuentoPorcentaje")
                        .HasColumnType("int");

                    b.Property<int>("Existencia")
                        .HasColumnType("int");

                    b.Property<int>("IdMarca")
                        .HasColumnType("int");

                    b.Property<string>("Imagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(19,4)");

                    b.Property<string>("Sku")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("SKU");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdProducto");

                    b.HasIndex("IdMarca");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("PruebaClase005.Models.dbModels.Resena", b =>
                {
                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<int>("IdProducto")
                        .HasColumnType("int");

                    b.Property<string>("Comentario")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("datetime");

                    b.Property<int>("Puntuacion")
                        .HasColumnType("int");

                    b.HasKey("IdUsuario", "IdProducto");

                    b.HasIndex("IdProducto");

                    b.ToTable("Resena");
                });

            modelBuilder.Entity("PruebaClase005.Models.dbModels.VentaDetalle", b =>
                {
                    b.Property<int>("IdVenta")
                        .HasColumnType("int");

                    b.Property<int>("IdProducto")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(19,4)");

                    b.HasKey("IdVenta", "IdProducto");

                    b.HasIndex("IdProducto");

                    b.ToTable("VentaDetalle");
                });

            modelBuilder.Entity("PruebaClase005.Models.dbModels.Ventum", b =>
                {
                    b.Property<int>("IdVenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVenta"), 1L, 1);

                    b.Property<DateTime>("FechaCompra")
                        .HasColumnType("datetime");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(19,4)");

                    b.HasKey("IdVenta");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Venta");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("PruebaClase005.Models.dbModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("PruebaClase005.Models.dbModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PruebaClase005.Models.dbModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("PruebaClase005.Models.dbModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PruebaClase005.Models.dbModels.Carrito", b =>
                {
                    b.HasOne("PruebaClase005.Models.dbModels.Producto", "IdProductoNavigation")
                        .WithMany("Carritos")
                        .HasForeignKey("IdProducto")
                        .IsRequired()
                        .HasConstraintName("FK_Carrito_Producto");

                    b.HasOne("PruebaClase005.Models.dbModels.ApplicationUser", "IdUsuarioNavigation")
                        .WithMany("Carritos")
                        .HasForeignKey("IdUsuario")
                        .IsRequired()
                        .HasConstraintName("FK_Carrito_Usuario");

                    b.Navigation("IdProductoNavigation");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("PruebaClase005.Models.dbModels.Deseado", b =>
                {
                    b.HasOne("PruebaClase005.Models.dbModels.Producto", "IdProductoNavigation")
                        .WithMany("Deseados")
                        .HasForeignKey("IdProducto")
                        .IsRequired()
                        .HasConstraintName("FK_Deseados_Producto");

                    b.HasOne("PruebaClase005.Models.dbModels.ApplicationUser", "IdUsuarioNavigation")
                        .WithMany("Deseados")
                        .HasForeignKey("IdUsuario")
                        .IsRequired()
                        .HasConstraintName("FK_Deseados_Usuario");

                    b.Navigation("IdProductoNavigation");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("PruebaClase005.Models.dbModels.Producto", b =>
                {
                    b.HasOne("PruebaClase005.Models.dbModels.Marca", "IdMarcaNavigation")
                        .WithMany("Productos")
                        .HasForeignKey("IdMarca")
                        .IsRequired()
                        .HasConstraintName("FK_Producto_Marca");

                    b.Navigation("IdMarcaNavigation");
                });

            modelBuilder.Entity("PruebaClase005.Models.dbModels.Resena", b =>
                {
                    b.HasOne("PruebaClase005.Models.dbModels.Producto", "IdProductoNavigation")
                        .WithMany("Resenas")
                        .HasForeignKey("IdProducto")
                        .IsRequired()
                        .HasConstraintName("FK_Resena_Producto");

                    b.HasOne("PruebaClase005.Models.dbModels.ApplicationUser", "IdUsuarioNavigation")
                        .WithMany("Resenas")
                        .HasForeignKey("IdUsuario")
                        .IsRequired()
                        .HasConstraintName("FK_Resena_Usuario");

                    b.Navigation("IdProductoNavigation");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("PruebaClase005.Models.dbModels.VentaDetalle", b =>
                {
                    b.HasOne("PruebaClase005.Models.dbModels.Producto", "IdProductoNavigation")
                        .WithMany("VentaDetalles")
                        .HasForeignKey("IdProducto")
                        .IsRequired()
                        .HasConstraintName("FK_VentaDetalle_Producto");

                    b.HasOne("PruebaClase005.Models.dbModels.Ventum", "IdVentaNavigation")
                        .WithMany("VentaDetalles")
                        .HasForeignKey("IdVenta")
                        .IsRequired()
                        .HasConstraintName("FK_VentaDetalle_Venta");

                    b.Navigation("IdProductoNavigation");

                    b.Navigation("IdVentaNavigation");
                });

            modelBuilder.Entity("PruebaClase005.Models.dbModels.Ventum", b =>
                {
                    b.HasOne("PruebaClase005.Models.dbModels.ApplicationUser", "IdUsuarioNavigation")
                        .WithMany("Venta")
                        .HasForeignKey("IdUsuario")
                        .IsRequired()
                        .HasConstraintName("FK_Venta_Usuario");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("PruebaClase005.Models.dbModels.ApplicationUser", b =>
                {
                    b.Navigation("Carritos");

                    b.Navigation("Deseados");

                    b.Navigation("Resenas");

                    b.Navigation("Venta");
                });

            modelBuilder.Entity("PruebaClase005.Models.dbModels.Marca", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("PruebaClase005.Models.dbModels.Producto", b =>
                {
                    b.Navigation("Carritos");

                    b.Navigation("Deseados");

                    b.Navigation("Resenas");

                    b.Navigation("VentaDetalles");
                });

            modelBuilder.Entity("PruebaClase005.Models.dbModels.Ventum", b =>
                {
                    b.Navigation("VentaDetalles");
                });
#pragma warning restore 612, 618
        }
    }
}
