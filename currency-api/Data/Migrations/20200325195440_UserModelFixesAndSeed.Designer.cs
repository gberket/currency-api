﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using currencyApi.Data;

namespace currency_api.Migrations
{
    [DbContext(typeof(CurrenciesContext))]
    [Migration("20200325195440_UserModelFixesAndSeed")]
    partial class UserModelFixesAndSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("currencyApi.Models.Currency", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nchar(3)")
                        .IsFixedLength(true)
                        .HasMaxLength(3);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedByUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedByUser")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("Currencies");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Code = "EUR",
                            CreatedAt = new DateTime(2020, 3, 25, 19, 54, 39, 955, DateTimeKind.Utc).AddTicks(5071),
                            Description = "Euro",
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 2L,
                            Code = "USD",
                            CreatedAt = new DateTime(2020, 3, 25, 19, 54, 39, 955, DateTimeKind.Utc).AddTicks(5131),
                            Description = "US Dollar",
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 3L,
                            Code = "CHF",
                            CreatedAt = new DateTime(2020, 3, 25, 19, 54, 39, 955, DateTimeKind.Utc).AddTicks(5133),
                            Description = "Swiss Franc",
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 4L,
                            Code = "GBP",
                            CreatedAt = new DateTime(2020, 3, 25, 19, 54, 39, 955, DateTimeKind.Utc).AddTicks(5135),
                            Description = "British Pound",
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 5L,
                            Code = "JPY",
                            CreatedAt = new DateTime(2020, 3, 25, 19, 54, 39, 955, DateTimeKind.Utc).AddTicks(5136),
                            Description = "Japan Yen",
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 6L,
                            Code = "CAD",
                            CreatedAt = new DateTime(2020, 3, 25, 19, 54, 39, 955, DateTimeKind.Utc).AddTicks(5138),
                            Description = "Canadian Dollar",
                            IsActive = true,
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("currencyApi.Models.CurrencyRate", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("BaseCurrencyId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedByUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("TargetCurrencyId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedByUser")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TargetCurrencyId");

                    b.HasIndex("BaseCurrencyId", "TargetCurrencyId")
                        .IsUnique();

                    b.ToTable("CurrencyRates");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            BaseCurrencyId = 1L,
                            CreatedAt = new DateTime(2020, 3, 25, 19, 54, 39, 955, DateTimeKind.Utc).AddTicks(6848),
                            IsActive = true,
                            IsDeleted = false,
                            Rate = 1.3764m,
                            TargetCurrencyId = 2L
                        },
                        new
                        {
                            Id = 2L,
                            BaseCurrencyId = 1L,
                            CreatedAt = new DateTime(2020, 3, 25, 19, 54, 39, 955, DateTimeKind.Utc).AddTicks(6919),
                            IsActive = true,
                            IsDeleted = false,
                            Rate = 1.2079m,
                            TargetCurrencyId = 3L
                        },
                        new
                        {
                            Id = 3L,
                            BaseCurrencyId = 1L,
                            CreatedAt = new DateTime(2020, 3, 25, 19, 54, 39, 955, DateTimeKind.Utc).AddTicks(6921),
                            IsActive = true,
                            IsDeleted = false,
                            Rate = 0.8731m,
                            TargetCurrencyId = 4L
                        },
                        new
                        {
                            Id = 4L,
                            BaseCurrencyId = 2L,
                            CreatedAt = new DateTime(2020, 3, 25, 19, 54, 39, 955, DateTimeKind.Utc).AddTicks(6923),
                            IsActive = true,
                            IsDeleted = false,
                            Rate = 76.7200m,
                            TargetCurrencyId = 5L
                        },
                        new
                        {
                            Id = 5L,
                            BaseCurrencyId = 3L,
                            CreatedAt = new DateTime(2020, 3, 25, 19, 54, 39, 955, DateTimeKind.Utc).AddTicks(6924),
                            IsActive = true,
                            IsDeleted = false,
                            Rate = 1.1379m,
                            TargetCurrencyId = 2L
                        },
                        new
                        {
                            Id = 6L,
                            BaseCurrencyId = 4L,
                            CreatedAt = new DateTime(2020, 3, 25, 19, 54, 39, 955, DateTimeKind.Utc).AddTicks(6926),
                            IsActive = true,
                            IsDeleted = false,
                            Rate = 1.5648m,
                            TargetCurrencyId = 6L
                        });
                });

            modelBuilder.Entity("currencyApi.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedByUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LockoutEnd")
                        .HasColumnType("datetime2");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedByUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            AccessFailedCount = 0,
                            CreatedAt = new DateTime(2020, 3, 25, 19, 54, 39, 953, DateTimeKind.Utc).AddTicks(9980),
                            Email = "user@currencies.cur",
                            IsActive = true,
                            IsDeleted = false,
                            LockoutEnabled = false,
                            PasswordHash = "xxx",
                            UserName = "admin"
                        },
                        new
                        {
                            Id = 2L,
                            AccessFailedCount = 0,
                            CreatedAt = new DateTime(2020, 3, 25, 19, 54, 39, 954, DateTimeKind.Utc).AddTicks(1223),
                            Email = "user@currencies.cur",
                            IsActive = true,
                            IsDeleted = false,
                            LockoutEnabled = false,
                            PasswordHash = "xxx",
                            UserName = "user"
                        });
                });

            modelBuilder.Entity("currencyApi.Models.UserRole", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("currencyApi.Models.UserRoleRelation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedByUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedByUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId", "RoleId")
                        .IsUnique();

                    b.ToTable("UserRoleRelations");
                });

            modelBuilder.Entity("currencyApi.Models.CurrencyRate", b =>
                {
                    b.HasOne("currencyApi.Models.Currency", "BaseCurrency")
                        .WithMany("CurrencyRates")
                        .HasForeignKey("BaseCurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("currencyApi.Models.Currency", "TargetCurrency")
                        .WithMany()
                        .HasForeignKey("TargetCurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("currencyApi.Models.UserRoleRelation", b =>
                {
                    b.HasOne("currencyApi.Models.UserRole", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("currencyApi.Models.User", "User")
                        .WithMany("UserRoleRelations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
