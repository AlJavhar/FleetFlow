﻿// <auto-generated />
using System;
using FleetFlow.DAL.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FleetFlow.DAL.Migrations
{
    [DbContext(typeof(FleetFlowDbContext))]
    [Migration("20230517141236_NullableAddressIdInOrderMigration")]
    partial class NullableAddressIdInOrderMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FleetFlow.Domain.Entities.Address", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<string>("District")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<double>("Latitude")
                        .HasColumnType("double precision");

                    b.Property<double>("Longitude")
                        .HasColumnType("double precision");

                    b.Property<string>("State")
                        .HasColumnType("text");

                    b.Property<string>("Street")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.Property<string>("ZipCode")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            City = "Navoi",
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 36, 720, DateTimeKind.Utc).AddTicks(5070),
                            District = "Nurata",
                            IsDeleted = false,
                            Latitude = 45.341200000000001,
                            Longitude = 32.323999999999998,
                            State = "Uzbekistan",
                            Street = "Medicals",
                            ZipCode = "210100"
                        },
                        new
                        {
                            Id = 2L,
                            City = "Andijan",
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 36, 720, DateTimeKind.Utc).AddTicks(5070),
                            District = "Paxtachi",
                            IsDeleted = false,
                            Latitude = 42.341200000000001,
                            Longitude = 20.324000000000002,
                            State = "Uzbekistan",
                            Street = "Programmers",
                            ZipCode = "213422"
                        },
                        new
                        {
                            Id = 3L,
                            City = "Bukhara",
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 36, 720, DateTimeKind.Utc).AddTicks(5080),
                            District = "Nurata",
                            IsDeleted = false,
                            Latitude = 44.341200000000001,
                            Longitude = 35.323999999999998,
                            State = "Uzbekistan",
                            Street = "Merchants",
                            ZipCode = "643224"
                        },
                        new
                        {
                            Id = 4L,
                            City = "Kharezm",
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 36, 720, DateTimeKind.Utc).AddTicks(5080),
                            District = "Nurata",
                            IsDeleted = false,
                            Latitude = 47.341200000000001,
                            Longitude = 27.324000000000002,
                            State = "Uzbekistan",
                            Street = "Policians",
                            ZipCode = "100250"
                        });
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Cart", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.CartItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<long>("CartId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Inventory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<long>("LocationId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("ProductId");

                    b.ToTable("Inventories");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Amount = 1000,
                            CreatedAt = new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Utc),
                            IsDeleted = false,
                            LocationId = 1L,
                            ProductId = 6L
                        },
                        new
                        {
                            Id = 2L,
                            Amount = 50,
                            CreatedAt = new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Utc),
                            IsDeleted = false,
                            LocationId = 1L,
                            ProductId = 1L
                        },
                        new
                        {
                            Id = 3L,
                            Amount = 100,
                            CreatedAt = new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Utc),
                            IsDeleted = false,
                            LocationId = 2L,
                            ProductId = 3L
                        },
                        new
                        {
                            Id = 4L,
                            Amount = 100000,
                            CreatedAt = new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Utc),
                            IsDeleted = false,
                            LocationId = 3L,
                            ProductId = 5L
                        },
                        new
                        {
                            Id = 5L,
                            Amount = 100,
                            CreatedAt = new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Utc),
                            IsDeleted = false,
                            LocationId = 3L,
                            ProductId = 2L
                        });
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Location", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Code = "a1",
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 34, 885, DateTimeKind.Utc).AddTicks(2090),
                            Description = "In the middle",
                            IsDeleted = false,
                            Type = 0
                        },
                        new
                        {
                            Id = 2L,
                            Code = "a2",
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 34, 885, DateTimeKind.Utc).AddTicks(2090),
                            Description = "In the beginning of entry",
                            IsDeleted = false,
                            Type = 0
                        },
                        new
                        {
                            Id = 3L,
                            Code = "i7",
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 34, 885, DateTimeKind.Utc).AddTicks(2090),
                            Description = "In the middle",
                            IsDeleted = false,
                            Type = 1
                        },
                        new
                        {
                            Id = 4L,
                            Code = "i9",
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 34, 885, DateTimeKind.Utc).AddTicks(2090),
                            Description = "In the middle",
                            IsDeleted = false,
                            Type = 0
                        },
                        new
                        {
                            Id = 5L,
                            Code = "m1",
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 34, 885, DateTimeKind.Utc).AddTicks(2100),
                            Description = "In the middle",
                            IsDeleted = false,
                            Type = 1
                        },
                        new
                        {
                            Id = 6L,
                            Code = "m2",
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 34, 885, DateTimeKind.Utc).AddTicks(2100),
                            Description = "In the middle",
                            IsDeleted = false,
                            Type = 0
                        });
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long?>("AddressId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("PaymentStatus")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            AddressId = 2L,
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 36, 720, DateTimeKind.Utc).AddTicks(5310),
                            IsDeleted = false,
                            PaymentStatus = 0,
                            Status = 1,
                            UserId = 1L
                        });
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.OrderItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<long>("OrderId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Amount = 1,
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 36, 720, DateTimeKind.Utc).AddTicks(5330),
                            IsDeleted = false,
                            OrderId = 1L,
                            ProductId = 3L
                        },
                        new
                        {
                            Id = 2L,
                            Amount = 4,
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 36, 720, DateTimeKind.Utc).AddTicks(5340),
                            IsDeleted = false,
                            OrderId = 1L,
                            ProductId = 6L
                        },
                        new
                        {
                            Id = 3L,
                            Amount = 2,
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 36, 720, DateTimeKind.Utc).AddTicks(5340),
                            IsDeleted = false,
                            OrderId = 1L,
                            ProductId = 2L
                        });
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("CategoryId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("Serial")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.Property<decimal>("Weight")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CategoryId = 1L,
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 36, 720, DateTimeKind.Utc).AddTicks(5120),
                            IsDeleted = false,
                            Name = "HP-Victus",
                            Price = 630m,
                            Serial = "a1B5",
                            Weight = 2.2m
                        },
                        new
                        {
                            Id = 2L,
                            CategoryId = 1L,
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 36, 720, DateTimeKind.Utc).AddTicks(5120),
                            IsDeleted = false,
                            Name = "MacBook-Pro",
                            Price = 2000m,
                            Serial = "AKJ-12445",
                            Weight = 1.2m
                        },
                        new
                        {
                            Id = 3L,
                            CategoryId = 5L,
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 36, 720, DateTimeKind.Utc).AddTicks(5120),
                            IsDeleted = false,
                            Name = "Iphone-14",
                            Price = 1500m,
                            Serial = "KLKJL-324342",
                            Weight = 0.1m
                        },
                        new
                        {
                            Id = 4L,
                            CategoryId = 6L,
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 36, 720, DateTimeKind.Utc).AddTicks(5130),
                            IsDeleted = false,
                            Name = "Spintronics",
                            Price = 100m,
                            Serial = "MMMLW-11234",
                            Weight = 4.2m
                        },
                        new
                        {
                            Id = 5L,
                            CategoryId = 4L,
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 36, 720, DateTimeKind.Utc).AddTicks(5130),
                            IsDeleted = false,
                            Name = "Trimol",
                            Price = 1m,
                            Serial = "MML-32423",
                            Weight = 0.002m
                        },
                        new
                        {
                            Id = 6L,
                            CategoryId = 2L,
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 36, 720, DateTimeKind.Utc).AddTicks(5130),
                            IsDeleted = false,
                            Name = "SmartWatch",
                            Price = 50m,
                            Serial = "JJJO-23423",
                            Weight = 0.1m
                        });
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.ProductCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 34, 885, DateTimeKind.Utc).AddTicks(1760),
                            IsDeleted = false,
                            Name = "Laptops"
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 34, 885, DateTimeKind.Utc).AddTicks(1760),
                            IsDeleted = false,
                            Name = "Accesories"
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 34, 885, DateTimeKind.Utc).AddTicks(1760),
                            IsDeleted = false,
                            Name = "Jewellery"
                        },
                        new
                        {
                            Id = 4L,
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 34, 885, DateTimeKind.Utc).AddTicks(1760),
                            IsDeleted = false,
                            Name = "Medicines"
                        },
                        new
                        {
                            Id = 5L,
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 34, 885, DateTimeKind.Utc).AddTicks(1770),
                            IsDeleted = false,
                            Name = "Telephones"
                        },
                        new
                        {
                            Id = 6L,
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 34, 885, DateTimeKind.Utc).AddTicks(1770),
                            IsDeleted = false,
                            Name = "Toys"
                        });
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 35, 69, DateTimeKind.Utc).AddTicks(4460),
                            Email = "dotnetgo@icloud.com",
                            FirstName = "Mukhammadkarim",
                            IsDeleted = false,
                            LastName = "Tukhtaboyev",
                            Password = "$2a$11$5lu/H0t7tr8qq68BiB8w6OpBE0ja/eVJUT3I7dmsU8WvL07pawrZ2",
                            Phone = "+998 991239999",
                            Role = 0
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 35, 253, DateTimeKind.Utc).AddTicks(5710),
                            Email = "wonderboy1w3@gmail.com",
                            FirstName = "Jamshid",
                            IsDeleted = false,
                            LastName = "Ma'ruf",
                            Password = "$2a$11$ynojTLGQSLS9jx8EBYiSQeK8AoWN2bhHchqy56q46hUjQxKy6S7yy",
                            Phone = "+998 991231999",
                            Role = 1
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 35, 436, DateTimeKind.Utc).AddTicks(8660),
                            Email = "kabeersolutions@gmail.com",
                            FirstName = "Kabeer",
                            IsDeleted = false,
                            LastName = "Solutions",
                            Password = "$2a$11$/DxXXjO/Gc7.QV0R8lpF0uU2Qza39VgoUOOPDL13hUVftlsxgkPKy",
                            Phone = "+998 991232999",
                            Role = 5
                        },
                        new
                        {
                            Id = 4L,
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 35, 620, DateTimeKind.Utc).AddTicks(3270),
                            Email = "nurillaewmuzaffar@gmail.com",
                            FirstName = "Muzaffar",
                            IsDeleted = false,
                            LastName = "Nurillayev",
                            Password = "$2a$11$Y/vdm1dWjgFFGw9JWzuy6e8mOfYwy2SK6NV0PyvG9zvO7mkbMVSdW",
                            Phone = "+998 995030110",
                            Role = 0
                        },
                        new
                        {
                            Id = 5L,
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 35, 804, DateTimeKind.Utc).AddTicks(690),
                            Email = "azimochilov@icloud.com",
                            FirstName = "Azim",
                            IsDeleted = false,
                            LastName = "Ochilov",
                            Password = "$2a$11$qgz4Ty599y56n/zVa9SVtedZdFstZ5mopyq07R1UQL3EMk8KmHkfW",
                            Phone = "+998 991233999",
                            Role = 2
                        },
                        new
                        {
                            Id = 6L,
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 35, 987, DateTimeKind.Utc).AddTicks(3010),
                            Email = "abdulloh@icloud.com",
                            FirstName = "Abdulloh",
                            IsDeleted = false,
                            LastName = "Ahmadjonov",
                            Password = "$2a$11$xkb/UjFTRGKLyOWSNxb.JO7U61k.0oiGX1vGuGBVasxungWesXEme",
                            Phone = "+998 991236999",
                            Role = 1
                        },
                        new
                        {
                            Id = 7L,
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 36, 170, DateTimeKind.Utc).AddTicks(8910),
                            Email = "komron2052@gmail.com",
                            FirstName = "Komron",
                            IsDeleted = false,
                            LastName = "Rahmonov",
                            Password = "$2a$11$tBst/WC3FQEAS/Lk4UNZKeYeeEJYxdNrWMrLR/8W0MTD0H0oeu.nO",
                            Phone = "+998 991234999",
                            Role = 4
                        },
                        new
                        {
                            Id = 8L,
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 36, 353, DateTimeKind.Utc).AddTicks(9700),
                            Email = "nozimjon@gmail.com",
                            FirstName = "Nozimjon",
                            IsDeleted = false,
                            LastName = "Usmonaliyev",
                            Password = "$2a$11$amI7JOEqsNVw80nbWOtopePna.P0xqqsLHnhpjr4xOi8lL8worDMa",
                            Phone = "+998 991235999",
                            Role = 3
                        },
                        new
                        {
                            Id = 9L,
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 36, 536, DateTimeKind.Utc).AddTicks(7660),
                            Email = "aljavhar@gmail.com",
                            FirstName = "AlJavhar",
                            IsDeleted = false,
                            LastName = "Boyaliyev",
                            Password = "$2a$11$tZM9AgVy.fX2B7m0O8c7tewxeGguTNXtjaZiyQsUxrjkRWxSn4uyO",
                            Phone = "+998 902344545",
                            Role = 0
                        },
                        new
                        {
                            Id = 10L,
                            CreatedAt = new DateTime(2023, 5, 17, 14, 12, 36, 720, DateTimeKind.Utc).AddTicks(4410),
                            Email = "muhammad@gmail.com",
                            FirstName = "Muhammad",
                            IsDeleted = false,
                            LastName = "Rahimboyev",
                            Password = "$2a$11$iTN4v9Oi1TPNuXWkN6MBKeAeLNDlpHepknk8t/q3OujKfLf5o/ZG.",
                            Phone = "+998 937770202",
                            Role = 0
                        });
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.CartItem", b =>
                {
                    b.HasOne("FleetFlow.Domain.Entities.Cart", "Cart")
                        .WithMany("Items")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FleetFlow.Domain.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Inventory", b =>
                {
                    b.HasOne("FleetFlow.Domain.Entities.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("FleetFlow.Domain.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Order", b =>
                {
                    b.HasOne("FleetFlow.Domain.Entities.Address", "Address")
                        .WithMany("Orders")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("FleetFlow.Domain.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.OrderItem", b =>
                {
                    b.HasOne("FleetFlow.Domain.Entities.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("FleetFlow.Domain.Entities.Product", "Product")
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Product", b =>
                {
                    b.HasOne("FleetFlow.Domain.Entities.ProductCategory", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Address", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Cart", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Product", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.ProductCategory", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}