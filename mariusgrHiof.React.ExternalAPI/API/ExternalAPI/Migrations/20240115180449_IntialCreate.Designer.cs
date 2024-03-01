﻿// <auto-generated />
using ExternalAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExternalAPI.Migrations
{
    [DbContext(typeof(CarContext))]
    [Migration("20240115180449_IntialCreate")]
    partial class IntialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ExternalAPI.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Hp")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearOfRelease")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Hp = 500,
                            ImageUrl = "someurl",
                            Make = "Nissan",
                            Model = "Skyline R34 GT-R",
                            YearOfRelease = 1999
                        },
                        new
                        {
                            Id = 2,
                            Hp = 300,
                            ImageUrl = "someurl",
                            Make = "Nissan",
                            Model = "350Z",
                            YearOfRelease = 1995
                        },
                        new
                        {
                            Id = 3,
                            Hp = 400,
                            ImageUrl = "someurl",
                            Make = "Nissan",
                            Model = "200sx",
                            YearOfRelease = 1999
                        });
                });
#pragma warning restore 612, 618
        }
    }
}