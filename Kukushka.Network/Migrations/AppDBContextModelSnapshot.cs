﻿// <auto-generated />
using System;
using Kukushka.Network.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Kukushka.Network.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("Kukushka.Network.Data.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte>("AcceptConnectionType")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("ActivityTime")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("BLOB");

                    b.Property<int>("FreeSpace")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("IP")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("BLOB");

                    b.Property<bool>("IsMobile")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsOnline")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("NickHash")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("Port")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("RsaOpenKey")
                        .HasColumnType("BLOB");

                    b.Property<byte>("TreeLevel")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
