﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserAPI.Models;

namespace UserAPI.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("UserAPI.Models.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2021, 1, 8, 21, 48, 25, 515, DateTimeKind.Local).AddTicks(2787),
                            Email = "Vardenis@Pavardenis.com",
                            FirstName = "Vardenis",
                            IsDeleted = false,
                            LastName = "Pavardenis",
                            Phone = "86******1"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2021, 1, 8, 21, 48, 25, 521, DateTimeKind.Local).AddTicks(1537),
                            Email = "Jonas@Jonaitis.com",
                            FirstName = "Jonas",
                            IsDeleted = false,
                            LastName = "Jonaitis",
                            Phone = "86******2"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2021, 1, 8, 21, 48, 25, 521, DateTimeKind.Local).AddTicks(1866),
                            Email = "Petras@Petraitis.com",
                            FirstName = "Petras",
                            IsDeleted = false,
                            LastName = "Petraitis",
                            Phone = "86******3"
                        });
                });

            modelBuilder.Entity("UserAPI.Models.Users.User", b =>
                {
                    b.HasOne("UserAPI.Models.Users.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.Navigation("CreatedBy");
                });
#pragma warning restore 612, 618
        }
    }
}
