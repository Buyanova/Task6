﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(ИнтернетмагазинContext))]
    [Migration("20230318152929_MigratonName")]
    partial class MigratonName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain.Models.Corzina", b =>
                {
                    b.Property<int>("IdZakaz")
                        .HasColumnType("int")
                        .HasColumnName("Id_zakaz");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<int>("IdTovara")
                        .HasColumnType("int")
                        .HasColumnName("Id_tovara");

                    b.Property<int>("Kolichestvo")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("StatusTovara")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Status_tovara");

                    b.HasKey("IdZakaz")
                        .HasName("PK__Corzina__EE5C9C9BE88374A1");

                    b.HasIndex("IdTovara");

                    b.ToTable("Corzina", (string)null);
                });

            modelBuilder.Entity("Domain.Models.HaracterysticaTovarov", b =>
                {
                    b.Property<int>("IdKategorii")
                        .HasColumnType("int")
                        .HasColumnName("Id_kategorii");

                    b.Property<string>("Brend")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Material")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NameKategorii")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Name_kategorii");

                    b.Property<string>("Proizvoditel")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Rasmer")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("StranaProizvoditelya")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Strana_proizvoditelya");

                    b.HasKey("IdKategorii")
                        .HasName("PK__Haracter__AEFCAE3E45265997");

                    b.ToTable("Haracterystica_tovarov", (string)null);
                });

            modelBuilder.Entity("Domain.Models.Pokupatel", b =>
                {
                    b.Property<int>("IdPokupatel")
                        .HasColumnType("int")
                        .HasColumnName("Id_pokupatel");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Fio")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("FIO");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.HasKey("IdPokupatel")
                        .HasName("PK__Pokupate__E1DD4D883C33D591");

                    b.ToTable("Pokupatel", (string)null);
                });

            modelBuilder.Entity("Domain.Models.Tovar", b =>
                {
                    b.Property<int>("IdTovara")
                        .HasColumnType("int")
                        .HasColumnName("Id_tovara");

                    b.Property<int>("IdKategorii")
                        .HasColumnType("int")
                        .HasColumnName("Id_kategorii");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("Kolichestvo")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("OpisanieTovara")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("Opisanie_tovara");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("IdTovara")
                        .HasName("PK__Tovar__95DB0B97106D7409");

                    b.HasIndex("IdKategorii");

                    b.ToTable("Tovar", (string)null);
                });

            modelBuilder.Entity("Domain.Models.Zakaz", b =>
                {
                    b.Property<DateTime>("DateZakaz")
                        .HasColumnType("date")
                        .HasColumnName("Date_zakaz");

                    b.Property<int>("IdPokupatel")
                        .HasColumnType("int")
                        .HasColumnName("Id_pokupatel");

                    b.Property<int>("IdZakaz")
                        .HasColumnType("int")
                        .HasColumnName("Id_zakaz");

                    b.Property<string>("SposobDostavci")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Sposob_dostavci");

                    b.Property<int>("SrokSborki")
                        .HasColumnType("int")
                        .HasColumnName("Srok_sborki");

                    b.Property<string>("StatusDostavci")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Status_dostavci");

                    b.HasIndex("IdPokupatel");

                    b.HasIndex("IdZakaz");

                    b.ToTable("Zakaz", (string)null);
                });

            modelBuilder.Entity("Domain.Models.Corzina", b =>
                {
                    b.HasOne("Domain.Models.Tovar", "IdTovaraNavigation")
                        .WithMany("Corzinas")
                        .HasForeignKey("IdTovara")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Corzina__Status___42E1EEFE");

                    b.Navigation("IdTovaraNavigation");
                });

            modelBuilder.Entity("Domain.Models.Tovar", b =>
                {
                    b.HasOne("Domain.Models.HaracterysticaTovarov", "IdKategoriiNavigation")
                        .WithMany("Tovars")
                        .HasForeignKey("IdKategorii")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Tovar__Id_katego__40058253");

                    b.Navigation("IdKategoriiNavigation");
                });

            modelBuilder.Entity("Domain.Models.Zakaz", b =>
                {
                    b.HasOne("Domain.Models.Pokupatel", "IdPokupatelNavigation")
                        .WithMany()
                        .HasForeignKey("IdPokupatel")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Zakaz__Status_do__4E53A1AA");

                    b.HasOne("Domain.Models.Corzina", "IdZakazNavigation")
                        .WithMany()
                        .HasForeignKey("IdZakaz")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Zakaz__Id_zakaz__4F47C5E3");

                    b.Navigation("IdPokupatelNavigation");

                    b.Navigation("IdZakazNavigation");
                });

            modelBuilder.Entity("Domain.Models.HaracterysticaTovarov", b =>
                {
                    b.Navigation("Tovars");
                });

            modelBuilder.Entity("Domain.Models.Tovar", b =>
                {
                    b.Navigation("Corzinas");
                });
#pragma warning restore 612, 618
        }
    }
}
