﻿// <auto-generated />
using System;
using EFCoreCFWithFluentAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreCFWithFluentAPI.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCoreCFWithFluentAPI.Entities.DonHang", b =>
                {
                    b.Property<Guid>("MaDh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChiGiao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayDat")
                        .HasColumnType("datetime2");

                    b.Property<string>("NguoiNhan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TinhTrangDonHang")
                        .HasColumnType("int");

                    b.Property<double>("TongTien")
                        .HasColumnType("float");

                    b.HasKey("MaDh");

                    b.ToTable("DonHang");
                });

            modelBuilder.Entity("EFCoreCFWithFluentAPI.Entities.DonHangChiTiet", b =>
                {
                    b.Property<Guid>("MaDh")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MaHh")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("DonGia")
                        .HasColumnType("float");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("MaDh", "MaHh");

                    b.HasIndex("MaHh");

                    b.ToTable("ChiTietDonHang");
                });

            modelBuilder.Entity("EFCoreCFWithFluentAPI.Entities.HangHoa", b =>
                {
                    b.Property<Guid>("MaHh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ChiTiet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DonGia")
                        .HasColumnType("float");

                    b.Property<string>("Hinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaLoai")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TenHh")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("MaHh");

                    b.HasIndex("MaLoai");

                    b.ToTable("HangHoa");
                });

            modelBuilder.Entity("EFCoreCFWithFluentAPI.Entities.Loai", b =>
                {
                    b.Property<int>("MaLoai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenLoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("MaLoai");

                    b.ToTable("Loai");
                });

            modelBuilder.Entity("EFCoreCFWithFluentAPI.Entities.DonHangChiTiet", b =>
                {
                    b.HasOne("EFCoreCFWithFluentAPI.Entities.DonHang", "DonHang")
                        .WithMany("DonHangChiTiets")
                        .HasForeignKey("MaDh")
                        .HasConstraintName("FK_CTDH_DonHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreCFWithFluentAPI.Entities.HangHoa", "HangHoa")
                        .WithMany("DonHangChiTiets")
                        .HasForeignKey("MaHh")
                        .HasConstraintName("FK_CTDH_HangHoa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFCoreCFWithFluentAPI.Entities.HangHoa", b =>
                {
                    b.HasOne("EFCoreCFWithFluentAPI.Entities.Loai", "Loai")
                        .WithMany("HangHoas")
                        .HasForeignKey("MaLoai")
                        .HasConstraintName("FK_HangHoa_Loai")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
