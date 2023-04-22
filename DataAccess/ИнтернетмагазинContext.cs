using System;
using System.Collections.Generic;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAccess
{
    public partial class ИнтернетмагазинContext : DbContext
    {
        public ИнтернетмагазинContext()
        {
        }

        public ИнтернетмагазинContext(DbContextOptions<ИнтернетмагазинContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Corzina> Corzinas { get; set; } = null!;
        public virtual DbSet<HaracterysticaTovarov> HaracterysticaTovarovs { get; set; } = null!;
        public virtual DbSet<Pokupatel> Pokupatels { get; set; } = null!;
        public virtual DbSet<Tovar> Tovars { get; set; } = null!;
        public virtual DbSet<Zakaz> Zakazs { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Corzina>(entity =>
            {
                entity.HasKey(e => e.IdZakaz)
                    .HasName("PK__Corzina__EE5C9C9BE88374A1");

                entity.ToTable("Corzina");

                entity.Property(e => e.IdZakaz)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_zakaz");

                entity.Property(e => e.IdTovara).HasColumnName("Id_tovara");

                entity.Property(e => e.StatusTovara)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Status_tovara");

                entity.HasOne(d => d.IdTovaraNavigation)
                    .WithMany(p => p.Corzinas)
                    .HasForeignKey(d => d.IdTovara)
                    .HasConstraintName("FK__Corzina__Status___42E1EEFE");
            });

            modelBuilder.Entity<HaracterysticaTovarov>(entity =>
            {
                entity.HasKey(e => e.IdKategorii)
                    .HasName("PK__Haracter__AEFCAE3E45265997");

                entity.ToTable("Haracterystica_tovarov");

                entity.Property(e => e.IdKategorii)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_kategorii");

                entity.Property(e => e.Brend)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Material)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NameKategorii)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Name_kategorii");

                entity.Property(e => e.Proizvoditel)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rasmer)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StranaProizvoditelya)
                    .HasMaxLength(100)
                    .HasColumnName("Strana_proizvoditelya");
            });

            modelBuilder.Entity<Pokupatel>(entity =>
            {
                entity.HasKey(e => e.IdPokupatel)
                    .HasName("PK__Pokupate__E1DD4D883C33D591");

                entity.ToTable("Pokupatel");

                entity.Property(e => e.IdPokupatel)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_pokupatel");

                entity.Property(e => e.Adres)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fio)
                    .HasMaxLength(1000)
                    .HasColumnName("FIO");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tovar>(entity =>
            {
                entity.HasKey(e => e.IdTovara)
                    .HasName("PK__Tovar__95DB0B97106D7409");

                entity.ToTable("Tovar");

                entity.Property(e => e.IdTovara)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_tovara");

                entity.Property(e => e.IdKategorii).HasColumnName("Id_kategorii");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OpisanieTovara)
                    .IsUnicode(false)
                    .HasColumnName("Opisanie_tovara");

                entity.HasOne(d => d.IdKategoriiNavigation)
                    .WithMany(p => p.Tovars)
                    .HasForeignKey(d => d.IdKategorii)
                    .HasConstraintName("FK__Tovar__Id_katego__40058253");
            });

            modelBuilder.Entity<Zakaz>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Zakaz");

                entity.Property(e => e.DateZakaz)
                    .HasColumnType("date")
                    .HasColumnName("Date_zakaz");

                entity.Property(e => e.IdPokupatel).HasColumnName("Id_pokupatel");

                entity.Property(e => e.IdZakaz).HasColumnName("Id_zakaz");

                entity.Property(e => e.SposobDostavci)
                    .HasMaxLength(100)
                    .HasColumnName("Sposob_dostavci");

                entity.Property(e => e.SrokSborki).HasColumnName("Srok_sborki");

                entity.Property(e => e.StatusDostavci)
                    .HasMaxLength(100)
                    .HasColumnName("Status_dostavci");

                entity.HasOne(d => d.IdPokupatelNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdPokupatel)
                    .HasConstraintName("FK__Zakaz__Status_do__4E53A1AA");

                entity.HasOne(d => d.IdZakazNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdZakaz)
                    .HasConstraintName("FK__Zakaz__Id_zakaz__4F47C5E3");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
