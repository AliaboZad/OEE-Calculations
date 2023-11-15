﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OEETest1.Data;

#nullable disable

namespace OEETest1.Migrations
{
    [DbContext(typeof(OEEDbContext))]
    partial class OEEDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OEETest1.Models.MachineLogs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("End_Time")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ShiftsId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Start_Time")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ShiftsId");

                    b.ToTable("machines");
                });

            modelBuilder.Entity("OEETest1.Models.ProductionLogs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Defective_parts")
                        .HasColumnType("int");

                    b.Property<int?>("ShiftsId")
                        .HasColumnType("int");

                    b.Property<int>("Total_parts_produced")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ShiftsId");

                    b.ToTable("productions");
                });

            modelBuilder.Entity("OEETest1.Models.Shifts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("End_Time")
                        .HasColumnType("datetime2");

                    b.Property<string>("Planed_dowentime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Start_Time")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("shifts");
                });

            modelBuilder.Entity("OEETest1.Models.MachineLogs", b =>
                {
                    b.HasOne("OEETest1.Models.Shifts", "Shifts")
                        .WithMany("MachineLogs")
                        .HasForeignKey("ShiftsId");

                    b.Navigation("Shifts");
                });

            modelBuilder.Entity("OEETest1.Models.ProductionLogs", b =>
                {
                    b.HasOne("OEETest1.Models.Shifts", "shifts")
                        .WithMany("productionLogs")
                        .HasForeignKey("ShiftsId");

                    b.Navigation("shifts");
                });

            modelBuilder.Entity("OEETest1.Models.Shifts", b =>
                {
                    b.Navigation("MachineLogs");

                    b.Navigation("productionLogs");
                });
#pragma warning restore 612, 618
        }
    }
}
