﻿// <auto-generated />
using System;
using EFCoreParkbeheer.DL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreParkbeheer.DL.Migrations
{
    [DbContext(typeof(ParkbeheerContext))]
    [Migration("20231225144717_initpark")]
    partial class initpark
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCoreParkbeheer.DL.Model.HuisEF", b =>
                {
                    b.Property<int>("HuisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HuisId"));

                    b.Property<bool>("Actief")
                        .HasColumnType("bit");

                    b.Property<int>("Nummer")
                        .HasColumnType("int");

                    b.Property<string>("ParkId")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Straat")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("HuisId");

                    b.HasIndex("ParkId");

                    b.ToTable("Huizen");
                });

            modelBuilder.Entity("EFCoreParkbeheer.DL.Model.HuurcontractEF", b =>
                {
                    b.Property<string>("HuurcontractId")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("AantalDagen")
                        .HasColumnType("int");

                    b.Property<DateTime>("EindDatum")
                        .HasColumnType("datetime2");

                    b.Property<int>("HuisId")
                        .HasColumnType("int");

                    b.Property<int>("HuurderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDatum")
                        .HasColumnType("datetime2");

                    b.HasKey("HuurcontractId");

                    b.HasIndex("HuisId");

                    b.HasIndex("HuurderId");

                    b.ToTable("Huurcontracten");
                });

            modelBuilder.Entity("EFCoreParkbeheer.DL.Model.HuurderEF", b =>
                {
                    b.Property<int>("HuurderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HuurderId"));

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefoon")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("HuurderId");

                    b.ToTable("Huurders");
                });

            modelBuilder.Entity("EFCoreParkbeheer.DL.Model.ParkEF", b =>
                {
                    b.Property<string>("ParkId")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Locatie")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("ParkId");

                    b.ToTable("Parken");
                });

            modelBuilder.Entity("EFCoreParkbeheer.DL.Model.HuisEF", b =>
                {
                    b.HasOne("EFCoreParkbeheer.DL.Model.ParkEF", "Park")
                        .WithMany("Huizen")
                        .HasForeignKey("ParkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Park");
                });

            modelBuilder.Entity("EFCoreParkbeheer.DL.Model.HuurcontractEF", b =>
                {
                    b.HasOne("EFCoreParkbeheer.DL.Model.HuisEF", "Huis")
                        .WithMany("Huurcontracten")
                        .HasForeignKey("HuisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreParkbeheer.DL.Model.HuurderEF", "Huurder")
                        .WithMany("Huurcontracten")
                        .HasForeignKey("HuurderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Huis");

                    b.Navigation("Huurder");
                });

            modelBuilder.Entity("EFCoreParkbeheer.DL.Model.HuisEF", b =>
                {
                    b.Navigation("Huurcontracten");
                });

            modelBuilder.Entity("EFCoreParkbeheer.DL.Model.HuurderEF", b =>
                {
                    b.Navigation("Huurcontracten");
                });

            modelBuilder.Entity("EFCoreParkbeheer.DL.Model.ParkEF", b =>
                {
                    b.Navigation("Huizen");
                });
#pragma warning restore 612, 618
        }
    }
}
