﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineTicariOtomasyon.Models.Siniflar;

#nullable disable

namespace OnlineTicariOtomasyon.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230522061524_mig_4")]
    partial class mig_4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("OnlineTicariOtomasyon.Models.Siniflar.Admin", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("KullaniciAd")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("Varchar");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("Varchar");

                    b.Property<string>("Yetki")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("Char");

                    b.HasKey("AdminID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("OnlineTicariOtomasyon.Models.Siniflar.Cariler", b =>
                {
                    b.Property<int>("CariID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CariAd")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar");

                    b.Property<string>("CariMail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CariSehir")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("Varchar");

                    b.Property<string>("CariSoyad")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar");

                    b.Property<bool>("Durum")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("CariID");

                    b.ToTable("Carilers");
                });

            modelBuilder.Entity("OnlineTicariOtomasyon.Models.Siniflar.Departman", b =>
                {
                    b.Property<int>("DepartmanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DepartmanAd")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar");

                    b.Property<bool>("Durum")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("DepartmanID");

                    b.ToTable("Departmans");
                });

            modelBuilder.Entity("OnlineTicariOtomasyon.Models.Siniflar.FaturaKalem", b =>
                {
                    b.Property<int>("FaturaKalemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("Varchar");

                    b.Property<decimal>("BirimFiyat")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("FaturalarFaturaID")
                        .HasColumnType("int");

                    b.Property<int>("Miktar")
                        .HasColumnType("int");

                    b.Property<decimal>("Tutar")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("FaturaKalemID");

                    b.HasIndex("FaturalarFaturaID");

                    b.ToTable("FaturaKalems");
                });

            modelBuilder.Entity("OnlineTicariOtomasyon.Models.Siniflar.Faturalar", b =>
                {
                    b.Property<int>("FaturaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FaturaSeriNo")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("Char");

                    b.Property<string>("FaturaSıraNo")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("Varchar");

                    b.Property<DateTime>("Saat")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("TeslimAlan")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar");

                    b.Property<string>("TeslimEden")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar");

                    b.Property<string>("VergiDairesi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("Varchar");

                    b.HasKey("FaturaID");

                    b.ToTable("Faturalars");
                });

            modelBuilder.Entity("OnlineTicariOtomasyon.Models.Siniflar.Gider", b =>
                {
                    b.Property<int>("GiderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("Varchar");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("Tutar")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("GiderID");

                    b.ToTable("Giders");
                });

            modelBuilder.Entity("OnlineTicariOtomasyon.Models.Siniflar.Kategori", b =>
                {
                    b.Property<int>("KategoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("KategoriAd")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar");

                    b.HasKey("KategoriID");

                    b.ToTable("Kategoris");
                });

            modelBuilder.Entity("OnlineTicariOtomasyon.Models.Siniflar.Personel", b =>
                {
                    b.Property<int>("PersonelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Departmanid")
                        .HasColumnType("int");

                    b.Property<string>("PersonelAd")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar");

                    b.Property<string>("PersonelGorsel")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("Varchar");

                    b.Property<string>("PersonelSoyad")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar");

                    b.HasKey("PersonelID");

                    b.HasIndex("Departmanid");

                    b.ToTable("Personels");
                });

            modelBuilder.Entity("OnlineTicariOtomasyon.Models.Siniflar.SatisHareket", b =>
                {
                    b.Property<int>("SatisID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Adet")
                        .HasColumnType("int");

                    b.Property<int>("Cariid")
                        .HasColumnType("int");

                    b.Property<int>("CarilerCariID")
                        .HasColumnType("int");

                    b.Property<decimal>("Fiyat")
                        .HasPrecision(8, 2)
                        .HasColumnType("decimal(8,2)");

                    b.Property<int>("Personelid")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("ToplamTutar")
                        .HasPrecision(8, 2)
                        .HasColumnType("decimal(8,2)");

                    b.Property<int>("Urunid")
                        .HasColumnType("int");

                    b.HasKey("SatisID");

                    b.HasIndex("CarilerCariID");

                    b.HasIndex("Personelid");

                    b.HasIndex("Urunid");

                    b.ToTable("SatisHarekets");
                });

            modelBuilder.Entity("OnlineTicariOtomasyon.Models.Siniflar.Urun", b =>
                {
                    b.Property<int>("UrunID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("AlisFiyat")
                        .HasPrecision(7, 2)
                        .HasColumnType("decimal(7,2)");

                    b.Property<bool>("Durum")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Kategoriid")
                        .HasColumnType("int");

                    b.Property<string>("Marka")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar");

                    b.Property<decimal>("SatisFiyat")
                        .HasPrecision(7, 2)
                        .HasColumnType("decimal(7,2)");

                    b.Property<short>("Stok")
                        .HasColumnType("smallint");

                    b.Property<string>("UrunAd")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar");

                    b.Property<string>("UrunGorsel")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("Varchar");

                    b.HasKey("UrunID");

                    b.HasIndex("Kategoriid");

                    b.ToTable("Uruns");
                });

            modelBuilder.Entity("OnlineTicariOtomasyon.Models.Siniflar.FaturaKalem", b =>
                {
                    b.HasOne("OnlineTicariOtomasyon.Models.Siniflar.Faturalar", "Faturalar")
                        .WithMany("FaturaKalems")
                        .HasForeignKey("FaturalarFaturaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faturalar");
                });

            modelBuilder.Entity("OnlineTicariOtomasyon.Models.Siniflar.Personel", b =>
                {
                    b.HasOne("OnlineTicariOtomasyon.Models.Siniflar.Departman", "Departman")
                        .WithMany("Personels")
                        .HasForeignKey("Departmanid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departman");
                });

            modelBuilder.Entity("OnlineTicariOtomasyon.Models.Siniflar.SatisHareket", b =>
                {
                    b.HasOne("OnlineTicariOtomasyon.Models.Siniflar.Cariler", "Cariler")
                        .WithMany("SatisHarekets")
                        .HasForeignKey("CarilerCariID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineTicariOtomasyon.Models.Siniflar.Personel", "Personel")
                        .WithMany("SatisHarekets")
                        .HasForeignKey("Personelid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineTicariOtomasyon.Models.Siniflar.Urun", "Urun")
                        .WithMany("SatisHarekets")
                        .HasForeignKey("Urunid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cariler");

                    b.Navigation("Personel");

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("OnlineTicariOtomasyon.Models.Siniflar.Urun", b =>
                {
                    b.HasOne("OnlineTicariOtomasyon.Models.Siniflar.Kategori", "Kategori")
                        .WithMany("Uruns")
                        .HasForeignKey("Kategoriid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("OnlineTicariOtomasyon.Models.Siniflar.Cariler", b =>
                {
                    b.Navigation("SatisHarekets");
                });

            modelBuilder.Entity("OnlineTicariOtomasyon.Models.Siniflar.Departman", b =>
                {
                    b.Navigation("Personels");
                });

            modelBuilder.Entity("OnlineTicariOtomasyon.Models.Siniflar.Faturalar", b =>
                {
                    b.Navigation("FaturaKalems");
                });

            modelBuilder.Entity("OnlineTicariOtomasyon.Models.Siniflar.Kategori", b =>
                {
                    b.Navigation("Uruns");
                });

            modelBuilder.Entity("OnlineTicariOtomasyon.Models.Siniflar.Personel", b =>
                {
                    b.Navigation("SatisHarekets");
                });

            modelBuilder.Entity("OnlineTicariOtomasyon.Models.Siniflar.Urun", b =>
                {
                    b.Navigation("SatisHarekets");
                });
#pragma warning restore 612, 618
        }
    }
}
