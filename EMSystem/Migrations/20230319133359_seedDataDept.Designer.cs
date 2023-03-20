﻿// <auto-generated />
using System;
using EMSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EMSystem.Migrations
{
    [DbContext(typeof(EMSDbContext))]
    [Migration("20230319133359_seedDataDept")]
    partial class seedDataDept
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EMSystem.Models.Department", b =>
                {
                    b.Property<int>("DeptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeptId"), 1L, 1);

                    b.Property<string>("DeptName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeptId");

                    b.ToTable("departments");

                    b.HasData(
                        new
                        {
                            DeptId = 1,
                            DeptName = "Information Technology"
                        },
                        new
                        {
                            DeptId = 2,
                            DeptName = "Human Resources"
                        },
                        new
                        {
                            DeptId = 3,
                            DeptName = "Marketing"
                        },
                        new
                        {
                            DeptId = 4,
                            DeptName = "Network Administration"
                        });
                });

            modelBuilder.Entity("EMSystem.Models.Employee", b =>
                {
                    b.Property<int>("EmpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpId"), 1L, 1);

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("employees");

                    b.HasData(
                        new
                        {
                            EmpId = 1,
                            DOB = new DateTime(2023, 3, 19, 21, 33, 58, 737, DateTimeKind.Local).AddTicks(4197),
                            DepartmentId = 1,
                            Email = "earljoseph@gmial.com",
                            Name = "Earl Joseph Ferran",
                            Phone = "09959632422"
                        },
                        new
                        {
                            EmpId = 2,
                            DOB = new DateTime(2023, 3, 19, 21, 33, 58, 737, DateTimeKind.Local).AddTicks(4214),
                            DepartmentId = 4,
                            Email = "batangQuipo@gmial.com",
                            Name = "Coco Martin",
                            Phone = "09023213749"
                        },
                        new
                        {
                            EmpId = 3,
                            DOB = new DateTime(2023, 3, 19, 21, 33, 58, 737, DateTimeKind.Local).AddTicks(4216),
                            DepartmentId = 2,
                            Email = "lizasoberano@gmial.com",
                            Name = "Liza Soberano",
                            Phone = "09023213749"
                        });
                });

            modelBuilder.Entity("EMSystem.Models.Employee", b =>
                {
                    b.HasOne("EMSystem.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });
#pragma warning restore 612, 618
        }
    }
}