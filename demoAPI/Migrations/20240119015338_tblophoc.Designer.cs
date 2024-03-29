﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using demoAPI.Data;

#nullable disable

namespace demoAPI.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20240119015338_tblophoc")]
    partial class tblophoc
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("demoAPI.Data.LopHoc", b =>
                {
                    b.Property<int>("MaLop")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MaLop"));

                    b.Property<Guid?>("MaSV")
                        .HasColumnType("uuid");

                    b.Property<string>("TenLop")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("MaLop");

                    b.HasIndex("MaSV");

                    b.ToTable("LopHoc");
                });

            modelBuilder.Entity("demoAPI.Data.SinhVienDB", b =>
                {
                    b.Property<Guid>("MaSV")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("DiaChi")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("SDT")
                        .HasColumnType("text");

                    b.Property<Guid?>("SinhVienDBMaSV")
                        .HasColumnType("uuid");

                    b.Property<string>("TenSV")
                        .HasColumnType("text");

                    b.HasKey("MaSV");

                    b.HasIndex("SinhVienDBMaSV");

                    b.ToTable("SinhVien");
                });

            modelBuilder.Entity("demoAPI.Data.LopHoc", b =>
                {
                    b.HasOne("demoAPI.Data.SinhVienDB", "SinhVienDB")
                        .WithMany()
                        .HasForeignKey("MaSV");

                    b.Navigation("SinhVienDB");
                });

            modelBuilder.Entity("demoAPI.Data.SinhVienDB", b =>
                {
                    b.HasOne("demoAPI.Data.SinhVienDB", null)
                        .WithMany("SinhVienDBs")
                        .HasForeignKey("SinhVienDBMaSV");
                });

            modelBuilder.Entity("demoAPI.Data.SinhVienDB", b =>
                {
                    b.Navigation("SinhVienDBs");
                });
#pragma warning restore 612, 618
        }
    }
}
