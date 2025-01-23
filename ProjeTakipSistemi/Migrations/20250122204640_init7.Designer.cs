﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjeTakipSistemi.Models.DBContext;

#nullable disable

namespace ProjeTakipSistemi.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20250122204640_init7")]
    partial class init7
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PersonelBilgileriPersonelProjeleri", b =>
                {
                    b.Property<int>("PersonelBilgilerisPersonelBilgileriId")
                        .HasColumnType("int");

                    b.Property<int>("PersonelProjelerisPersonelProjeId")
                        .HasColumnType("int");

                    b.HasKey("PersonelBilgilerisPersonelBilgileriId", "PersonelProjelerisPersonelProjeId");

                    b.HasIndex("PersonelProjelerisPersonelProjeId");

                    b.ToTable("PersonelBilgileriPersonelProjeleri");
                });

            modelBuilder.Entity("ProjeTakipSistemi.Models.GorevAtama.PersonelProjeleri", b =>
                {
                    b.Property<int>("PersonelProjeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonelProjeId"));

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("OncelikDurumu")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("ProjeAciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjeBaslik")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("TamamlanmaDurumu")
                        .HasColumnType("bit");

                    b.Property<int>("TamamlanmaOrani")
                        .HasColumnType("int");

                    b.Property<DateTime?>("TamamlanmaTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("PersonelProjeId");

                    b.ToTable("PersonelProjeleri");
                });

            modelBuilder.Entity("ProjeTakipSistemi.Models.Personel.PersonelBilgileri", b =>
                {
                    b.Property<int>("PersonelBilgileriId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonelBilgileriId"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("AdSoyad")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Departman")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Eposta")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Gorev")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime?>("IseGirisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("MedeniHal")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("PozisyonAciklama")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("TCNO")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("TelNo")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("YakinTC")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("YakinTel")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("YakinlikBilgisi")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Yetki")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PersonelBilgileriId");

                    b.ToTable("PersonelBilgileris");
                });

            modelBuilder.Entity("PersonelBilgileriPersonelProjeleri", b =>
                {
                    b.HasOne("ProjeTakipSistemi.Models.Personel.PersonelBilgileri", null)
                        .WithMany()
                        .HasForeignKey("PersonelBilgilerisPersonelBilgileriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjeTakipSistemi.Models.GorevAtama.PersonelProjeleri", null)
                        .WithMany()
                        .HasForeignKey("PersonelProjelerisPersonelProjeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
