﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StyleTee.Data;

#nullable disable

namespace SD61_BanAo.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StyleTee.Models.ChatLieu", b =>
                {
                    b.Property<Guid>("ID_ChatLieu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("tenChatLieu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("ID_ChatLieu");

                    b.ToTable("ChatLieu");
                });

            modelBuilder.Entity("StyleTee.Models.DanhMuc", b =>
                {
                    b.Property<Guid>("ID_DanhMuc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("tenDanhMuc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("ID_DanhMuc");

                    b.ToTable("DanhMuc");
                });

            modelBuilder.Entity("StyleTee.Models.DiaChi", b =>
                {
                    b.Property<Guid>("ID_DiaChi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ID_TaiKhoan")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TaiKhoanID_TaiKhoan")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("huyen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soNha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tinhThanhPho")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("trangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("xa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_DiaChi");

                    b.HasIndex("TaiKhoanID_TaiKhoan");

                    b.ToTable("DiaChi");
                });

            modelBuilder.Entity("StyleTee.Models.HinhAnh", b =>
                {
                    b.Property<Guid>("ID_HinhAnh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ID_SanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ID_SanPhamChiTiet")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("url_hinhAnh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_HinhAnh");

                    b.HasIndex("ID_SanPham");

                    b.HasIndex("ID_SanPhamChiTiet");

                    b.ToTable("HinhAnh");
                });

            modelBuilder.Entity("StyleTee.Models.KichThuoc", b =>
                {
                    b.Property<Guid>("ID_KichThuoc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("moTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenKichThuoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("ID_KichThuoc");

                    b.ToTable("KichThuoc");
                });

            modelBuilder.Entity("StyleTee.Models.MauSac", b =>
                {
                    b.Property<Guid>("ID_MauSac")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("tenMauSac")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("ID_MauSac");

                    b.ToTable("MauSac");
                });

            modelBuilder.Entity("StyleTee.Models.SanPham", b =>
                {
                    b.Property<Guid>("ID_SanPham")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("giaGoc")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("moTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenSanPham")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("ID_SanPham");

                    b.ToTable("SanPham");
                });

            modelBuilder.Entity("StyleTee.Models.SanPhamChiTiet", b =>
                {
                    b.Property<Guid>("ID_SanPhamChiTiet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ChatLieuID_ChatLieu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DanhMucID_DanhMuc")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Gia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("ID_ChatLieu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ID_DanhMuc")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ID_Mau")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ID_SanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ID_Size")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ID_ThuongHieu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ID_XuatXu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("KichThuocID_KichThuoc")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MauSacID_MauSac")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SanPhamID_SanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ThuongHieuID_ThuongHieu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("XuatXuID_XuatXu")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID_SanPhamChiTiet");

                    b.HasIndex("ChatLieuID_ChatLieu");

                    b.HasIndex("DanhMucID_DanhMuc");

                    b.HasIndex("KichThuocID_KichThuoc");

                    b.HasIndex("MauSacID_MauSac");

                    b.HasIndex("SanPhamID_SanPham");

                    b.HasIndex("ThuongHieuID_ThuongHieu");

                    b.HasIndex("XuatXuID_XuatXu");

                    b.ToTable("SanPhamChiTiet");
                });

            modelBuilder.Entity("StyleTee.Models.TaiKhoan", b =>
                {
                    b.Property<Guid>("ID_TaiKhoan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ID_VaiTro")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gioiTinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hoTen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("matKhau")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("ngaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("soDienThoai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("taiKhoan")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("trangThai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_TaiKhoan");

                    b.HasIndex("ID_VaiTro")
                        .IsUnique();

                    b.ToTable("TaiKhoan");
                });

            modelBuilder.Entity("StyleTee.Models.ThuongHieu", b =>
                {
                    b.Property<Guid>("ID_ThuongHieu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("tenThuongHieu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("ID_ThuongHieu");

                    b.ToTable("ThuongHieu");
                });

            modelBuilder.Entity("StyleTee.Models.VaiTro", b =>
                {
                    b.Property<Guid>("ID_VaiTro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ID_TaiKhoan")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("tenVaiTro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_VaiTro");

                    b.ToTable("VaiTro");
                });

            modelBuilder.Entity("StyleTee.Models.XuatXu", b =>
                {
                    b.Property<Guid>("ID_XuatXu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("tenXuatXu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("ID_XuatXu");

                    b.ToTable("XuatXu");
                });

            modelBuilder.Entity("StyleTee.Models.DiaChi", b =>
                {
                    b.HasOne("StyleTee.Models.TaiKhoan", "TaiKhoan")
                        .WithMany()
                        .HasForeignKey("TaiKhoanID_TaiKhoan")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TaiKhoan");
                });

            modelBuilder.Entity("StyleTee.Models.HinhAnh", b =>
                {
                    b.HasOne("StyleTee.Models.SanPham", "SanPham")
                        .WithMany("HinhAnh")
                        .HasForeignKey("ID_SanPham")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("StyleTee.Models.SanPhamChiTiet", "SanPhamChiTiet")
                        .WithMany("HinhAnh")
                        .HasForeignKey("ID_SanPhamChiTiet")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("SanPham");

                    b.Navigation("SanPhamChiTiet");
                });

            modelBuilder.Entity("StyleTee.Models.SanPhamChiTiet", b =>
                {
                    b.HasOne("StyleTee.Models.ChatLieu", "ChatLieu")
                        .WithMany("SanPham")
                        .HasForeignKey("ChatLieuID_ChatLieu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StyleTee.Models.DanhMuc", "DanhMuc")
                        .WithMany("SanPham")
                        .HasForeignKey("DanhMucID_DanhMuc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StyleTee.Models.KichThuoc", "KichThuoc")
                        .WithMany("SanPham")
                        .HasForeignKey("KichThuocID_KichThuoc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StyleTee.Models.MauSac", "MauSac")
                        .WithMany("SanPham")
                        .HasForeignKey("MauSacID_MauSac")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StyleTee.Models.SanPham", "SanPham")
                        .WithMany()
                        .HasForeignKey("SanPhamID_SanPham")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StyleTee.Models.ThuongHieu", "ThuongHieu")
                        .WithMany("SanPham")
                        .HasForeignKey("ThuongHieuID_ThuongHieu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StyleTee.Models.XuatXu", "XuatXu")
                        .WithMany("SanPham")
                        .HasForeignKey("XuatXuID_XuatXu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChatLieu");

                    b.Navigation("DanhMuc");

                    b.Navigation("KichThuoc");

                    b.Navigation("MauSac");

                    b.Navigation("SanPham");

                    b.Navigation("ThuongHieu");

                    b.Navigation("XuatXu");
                });

            modelBuilder.Entity("StyleTee.Models.TaiKhoan", b =>
                {
                    b.HasOne("StyleTee.Models.VaiTro", "VaiTro")
                        .WithOne("TaiKhoan")
                        .HasForeignKey("StyleTee.Models.TaiKhoan", "ID_VaiTro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VaiTro");
                });

            modelBuilder.Entity("StyleTee.Models.ChatLieu", b =>
                {
                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("StyleTee.Models.DanhMuc", b =>
                {
                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("StyleTee.Models.KichThuoc", b =>
                {
                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("StyleTee.Models.MauSac", b =>
                {
                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("StyleTee.Models.SanPham", b =>
                {
                    b.Navigation("HinhAnh");
                });

            modelBuilder.Entity("StyleTee.Models.SanPhamChiTiet", b =>
                {
                    b.Navigation("HinhAnh");
                });

            modelBuilder.Entity("StyleTee.Models.ThuongHieu", b =>
                {
                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("StyleTee.Models.VaiTro", b =>
                {
                    b.Navigation("TaiKhoan")
                        .IsRequired();
                });

            modelBuilder.Entity("StyleTee.Models.XuatXu", b =>
                {
                    b.Navigation("SanPham");
                });
#pragma warning restore 612, 618
        }
    }
}
