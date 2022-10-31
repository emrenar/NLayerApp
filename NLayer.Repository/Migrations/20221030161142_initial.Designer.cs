﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NLayer.Repository;

#nullable disable

namespace NLayer.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221030161142_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("NLayer.Core.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Kalemler",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Kitaplar",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Defterler",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("NLayer.Core.Concrete.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2022, 10, 30, 19, 11, 42, 53, DateTimeKind.Local).AddTicks(8728),
                            Price = 200m,
                            ProductName = "Kalem1",
                            Stock = 20
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2022, 10, 30, 19, 11, 42, 53, DateTimeKind.Local).AddTicks(8737),
                            Price = 250m,
                            ProductName = "Kalem2",
                            Stock = 10
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2022, 10, 30, 19, 11, 42, 53, DateTimeKind.Local).AddTicks(8739),
                            Price = 300m,
                            ProductName = "Kalem3",
                            Stock = 50
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2022, 10, 30, 19, 11, 42, 53, DateTimeKind.Local).AddTicks(8741),
                            Price = 550m,
                            ProductName = "Kitap1",
                            Stock = 5
                        });
                });

            modelBuilder.Entity("NLayer.Core.Concrete.ProductFeature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("ProductFeatures");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "Kırmızı",
                            Height = 100,
                            ProductId = 1,
                            Width = 200
                        },
                        new
                        {
                            Id = 2,
                            Color = "Mavi",
                            Height = 500,
                            ProductId = 2,
                            Width = 400
                        });
                });

            modelBuilder.Entity("NLayer.Core.Concrete.Product", b =>
                {
                    b.HasOne("NLayer.Core.Concrete.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("NLayer.Core.Concrete.ProductFeature", b =>
                {
                    b.HasOne("NLayer.Core.Concrete.Product", "Product")
                        .WithOne("ProductFeature")
                        .HasForeignKey("NLayer.Core.Concrete.ProductFeature", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("NLayer.Core.Concrete.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("NLayer.Core.Concrete.Product", b =>
                {
                    b.Navigation("ProductFeature")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
