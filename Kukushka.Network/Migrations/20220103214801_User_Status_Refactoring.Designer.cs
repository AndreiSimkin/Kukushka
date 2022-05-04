﻿// <auto-generated />
using System;
using Kukushka.Network.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Kukushka.Network.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20220103214801_User_Status_Refactoring")]
    partial class User_Status_Refactoring
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("Kukushka.Network.Data.Models.User", b =>
                {
                    b.Property<byte[]>("Id")
                        .HasColumnType("BLOB");

                    b.Property<byte>("AcceptConnectionType")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("ActivityTime")
                        .HasColumnType("BLOB");

                    b.Property<int>("FreeSpace")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("IP")
                        .HasColumnType("BLOB");

                    b.Property<bool>("IsMobile")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsOnline")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Port")
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
