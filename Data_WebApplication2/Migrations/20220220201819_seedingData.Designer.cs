﻿// <auto-generated />
using Data_WebApplication2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data_WebApplication2.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20220220201819_seedingData")]
    partial class seedingData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Data_WebApplication2.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("City");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            Name = "StockHolm"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 1,
                            Name = "Gotenburg"
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 1,
                            Name = "Uppsala"
                        });
                });

            modelBuilder.Entity("Data_WebApplication2.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Country");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Sweden"
                        });
                });

            modelBuilder.Entity("Data_WebApplication2.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            Name = "William",
                            PhoneNumber = "12345678"
                        });
                });

            modelBuilder.Entity("Data_WebApplication2.Models.City", b =>
                {
                    b.HasOne("Data_WebApplication2.Models.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data_WebApplication2.Models.Person", b =>
                {
                    b.HasOne("Data_WebApplication2.Models.City", "City")
                        .WithMany("Person")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}