﻿// <auto-generated />
using System;
using Blazorproyect.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(InventaryContext))]
    [Migration("20241117190157_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.35")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Blazorproyect.Entity.AlmacenEntity", b =>
                {
                    b.Property<string>("AlmacenId")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("AlmacenDireccion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("AlmacenName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("AlmacenId");

                    b.ToTable("Almacenes");

                    b.HasData(
                        new
                        {
                            AlmacenId = "c0d32e41-5f5f-4814-9f4f-1b683b06a696",
                            AlmacenDireccion = "Por ahi",
                            AlmacenName = "Almacen central"
                        },
                        new
                        {
                            AlmacenId = "95061144-0e72-4586-8f63-4d0fb9827fba",
                            AlmacenDireccion = "Frailes 1",
                            AlmacenName = "Almacen de Los Frailes 1 "
                        },
                        new
                        {
                            AlmacenId = "86c10bba-db71-440e-9a75-f4a95ea7ab76",
                            AlmacenDireccion = "Frailes 2",
                            AlmacenName = "Almacen de Los Frailes 2"
                        },
                        new
                        {
                            AlmacenId = "f7413f13-22a4-4b8d-a2ba-03f4218750c1",
                            AlmacenDireccion = "Tame Impala",
                            AlmacenName = "Almacen Tame Impala"
                        });
                });

            modelBuilder.Entity("Blazorproyect.Entity.BodegaEntity", b =>
                {
                    b.Property<string>("BodegaId")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("AlmacenId")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("CatidadParcial")
                        .HasColumnType("int");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime>("UltimaActualizacion")
                        .HasColumnType("datetime(6)");

                    b.HasKey("BodegaId");

                    b.HasIndex("AlmacenId");

                    b.HasIndex("ProductId");

                    b.ToTable("Bodegas");
                });

            modelBuilder.Entity("Blazorproyect.Entity.CategoryEntity", b =>
                {
                    b.Property<string>("categoryId")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("categoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("categoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            categoryId = "ASH",
                            categoryName = "Aseo Hogar"
                        },
                        new
                        {
                            categoryId = "ASP",
                            categoryName = "Aseo Personal"
                        },
                        new
                        {
                            categoryId = "HGR",
                            categoryName = "Hogar"
                        },
                        new
                        {
                            categoryId = "PRF",
                            categoryName = "Perfumeria"
                        },
                        new
                        {
                            categoryId = "SLD",
                            categoryName = "Salud"
                        },
                        new
                        {
                            categoryId = "VDJ",
                            categoryName = "Video Juegos"
                        });
                });

            modelBuilder.Entity("Blazorproyect.Entity.IngresosySalidasEntity", b =>
                {
                    b.Property<string>("IngresoId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("BodegaId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("BodegasBodegaId")
                        .HasColumnType("varchar(10)");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("IngresoFecha")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("Isinput")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("IngresoId");

                    b.HasIndex("BodegasBodegaId");

                    b.ToTable("ingresosySalidas");
                });

            modelBuilder.Entity("Blazorproyect.Entity.ProductEntity", b =>
                {
                    b.Property<string>("ProductId")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("varchar(600)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("ProductQuantity")
                        .HasColumnType("int");

                    b.Property<string>("categoryId")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("ProductId");

                    b.HasIndex("categoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Blazorproyect.Entity.BodegaEntity", b =>
                {
                    b.HasOne("Blazorproyect.Entity.AlmacenEntity", "Almacen")
                        .WithMany("Bodegas")
                        .HasForeignKey("AlmacenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blazorproyect.Entity.ProductEntity", "Product")
                        .WithMany("Bodegas")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Almacen");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Blazorproyect.Entity.IngresosySalidasEntity", b =>
                {
                    b.HasOne("Blazorproyect.Entity.BodegaEntity", "Bodegas")
                        .WithMany("ingresosySalidas")
                        .HasForeignKey("BodegasBodegaId");

                    b.Navigation("Bodegas");
                });

            modelBuilder.Entity("Blazorproyect.Entity.ProductEntity", b =>
                {
                    b.HasOne("Blazorproyect.Entity.CategoryEntity", "Category")
                        .WithMany("Products")
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Blazorproyect.Entity.AlmacenEntity", b =>
                {
                    b.Navigation("Bodegas");
                });

            modelBuilder.Entity("Blazorproyect.Entity.BodegaEntity", b =>
                {
                    b.Navigation("ingresosySalidas");
                });

            modelBuilder.Entity("Blazorproyect.Entity.CategoryEntity", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Blazorproyect.Entity.ProductEntity", b =>
                {
                    b.Navigation("Bodegas");
                });
#pragma warning restore 612, 618
        }
    }
}
