﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MottuSmartPatio.Data;

#nullable disable

namespace MottuSmartPatio.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.5");

            modelBuilder.Entity("MottuSmartPatio.Models.Moto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nclob");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("nclob");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nclob");

                    b.HasKey("Id");

                    b.ToTable("Motos");
                });
#pragma warning restore 612, 618
        }
    }
}
