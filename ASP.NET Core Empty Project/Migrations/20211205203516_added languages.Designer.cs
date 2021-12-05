﻿// <auto-generated />
using ASP.NET_Core_Empty_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASP.NET_Core_Empty_Project.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211205203516_added languages")]
    partial class addedlanguages
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASP.NET_Core_Empty_Project.Models.CityDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 46,
                            Name = "Göteborg"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 46,
                            Name = "Stockholm"
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 46,
                            Name = "Malmö"
                        },
                        new
                        {
                            Id = 4,
                            CountryId = 47,
                            Name = "Oslo"
                        },
                        new
                        {
                            Id = 5,
                            CountryId = 358,
                            Name = "Helsinki"
                        });
                });

            modelBuilder.Entity("ASP.NET_Core_Empty_Project.Models.CountryDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 46,
                            Name = "Sweden"
                        },
                        new
                        {
                            Id = 47,
                            Name = "Norway"
                        },
                        new
                        {
                            Id = 358,
                            Name = "Finland"
                        });
                });

            modelBuilder.Entity("ASP.NET_Core_Empty_Project.Models.LanguageDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("ASP.NET_Core_Empty_Project.Models.PersonDb", b =>
                {
                    b.Property<string>("SSN")
                        .HasColumnType("nvarchar(13)")
                        .HasMaxLength(13);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SSN");

                    b.HasIndex("CityId");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            SSN = "19890209-1234",
                            CityId = 1,
                            Name = "Albin de Val",
                            PhoneNr = "0721222324"
                        },
                        new
                        {
                            SSN = "19700707-4321",
                            CityId = 2,
                            Name = "Håkan Svensson",
                            PhoneNr = "031555666777"
                        },
                        new
                        {
                            SSN = "19801010-4125",
                            CityId = 3,
                            Name = "Anders Andersson",
                            PhoneNr = "01234567"
                        },
                        new
                        {
                            SSN = "20000909-0909",
                            CityId = 4,
                            Name = "Max Verstappen",
                            PhoneNr = "528582685"
                        });
                });

            modelBuilder.Entity("ASP.NET_Core_Empty_Project.Models.PersonLanguage", b =>
                {
                    b.Property<string>("PersonId")
                        .HasColumnType("nvarchar(13)");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.HasKey("PersonId", "LanguageId");

                    b.HasIndex("LanguageId");

                    b.ToTable("PersonLanguage");
                });

            modelBuilder.Entity("ASP.NET_Core_Empty_Project.Models.CityDb", b =>
                {
                    b.HasOne("ASP.NET_Core_Empty_Project.Models.CountryDb", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASP.NET_Core_Empty_Project.Models.PersonDb", b =>
                {
                    b.HasOne("ASP.NET_Core_Empty_Project.Models.CityDb", "City")
                        .WithMany("Persons")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASP.NET_Core_Empty_Project.Models.PersonLanguage", b =>
                {
                    b.HasOne("ASP.NET_Core_Empty_Project.Models.LanguageDb", "Language")
                        .WithMany("PersonLanguage")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASP.NET_Core_Empty_Project.Models.PersonDb", "Person")
                        .WithMany("PersonLanguage")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
