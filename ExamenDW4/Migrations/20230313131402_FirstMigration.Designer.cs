﻿// <auto-generated />
using System;
using ExamenDW4.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExamenDW4.Migrations
{
    [DbContext(typeof(Bails))]
    [Migration("20230313131402_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ExamenDW4.Models.Appartement", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<bool>("Meuble")
                        .HasColumnType("bit");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<int>("Surface")
                        .HasColumnType("int");

                    b.Property<int>("TypeAppartement")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Appartements");
                });

            modelBuilder.Entity("ExamenDW4.Models.Locataire", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Locataires");
                });

            modelBuilder.Entity("ExamenDW4.Models.Location", b =>
                {
                    b.Property<int>("AppartementID")
                        .HasColumnType("int");

                    b.Property<int>("LocataireID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateDebut")
                        .HasColumnType("date");

                    b.Property<DateTime>("DateFin")
                        .HasColumnType("date");

                    b.Property<int>("LoyerMensuel")
                        .HasColumnType("int");

                    b.HasKey("AppartementID", "LocataireID", "DateDebut");

                    b.HasIndex("LocataireID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("ExamenDW4.Models.Location", b =>
                {
                    b.HasOne("ExamenDW4.Models.Appartement", "Appartement")
                        .WithMany("Locations")
                        .HasForeignKey("AppartementID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExamenDW4.Models.Locataire", "Locataire")
                        .WithMany("Locations")
                        .HasForeignKey("LocataireID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appartement");

                    b.Navigation("Locataire");
                });

            modelBuilder.Entity("ExamenDW4.Models.Appartement", b =>
                {
                    b.Navigation("Locations");
                });

            modelBuilder.Entity("ExamenDW4.Models.Locataire", b =>
                {
                    b.Navigation("Locations");
                });
#pragma warning restore 612, 618
        }
    }
}
