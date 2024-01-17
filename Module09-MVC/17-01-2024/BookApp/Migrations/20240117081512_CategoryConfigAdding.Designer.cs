﻿// <auto-generated />
using System;
using BookApp.Models.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240117081512_CategoryConfigAdding")]
    partial class CategoryConfigAdding
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookApp.Models.Entitys.Concrete.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Abstract")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsHome")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PageCount")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<string>("URL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BookApp.Models.Entitys.Concrete.BookCategory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("BookCategories");
                });

            modelBuilder.Entity("BookApp.Models.Entitys.Concrete.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedDate = new DateTime(2024, 1, 17, 11, 15, 12, 925, DateTimeKind.Local).AddTicks(2647),
                            Description = "Genel kategorisine sahip ve kategorisiz kitaplar burada olacak",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 1, 17, 11, 15, 12, 925, DateTimeKind.Local).AddTicks(2660),
                            Name = "Genel",
                            URL = "genel"
                        },
                        new
                        {
                            ID = 2,
                            CreatedDate = new DateTime(2024, 1, 17, 11, 15, 12, 925, DateTimeKind.Local).AddTicks(2664),
                            Description = "Bilim kurgu kitapları",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 1, 17, 11, 15, 12, 925, DateTimeKind.Local).AddTicks(2664),
                            Name = "Bilim Kurgu",
                            URL = "bilim-kurgu"
                        },
                        new
                        {
                            ID = 3,
                            CreatedDate = new DateTime(2024, 1, 17, 11, 15, 12, 925, DateTimeKind.Local).AddTicks(2665),
                            Description = "Distopik kitaplar",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 1, 17, 11, 15, 12, 925, DateTimeKind.Local).AddTicks(2665),
                            Name = "Distopya",
                            URL = "distopya"
                        },
                        new
                        {
                            ID = 4,
                            CreatedDate = new DateTime(2024, 1, 17, 11, 15, 12, 925, DateTimeKind.Local).AddTicks(2666),
                            Description = "Bilim ve Mühendislik Kitapları",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 1, 17, 11, 15, 12, 925, DateTimeKind.Local).AddTicks(2666),
                            Name = "Bilim Ve Mühendislik",
                            URL = "bilim-ve-muhendislik"
                        },
                        new
                        {
                            ID = 5,
                            CreatedDate = new DateTime(2024, 1, 17, 11, 15, 12, 925, DateTimeKind.Local).AddTicks(2667),
                            Description = "Dünya tarihi ile ilgili kitaplar",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 1, 17, 11, 15, 12, 925, DateTimeKind.Local).AddTicks(2668),
                            Name = "Dünya Tarihi",
                            URL = "dunya-tarihi"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
