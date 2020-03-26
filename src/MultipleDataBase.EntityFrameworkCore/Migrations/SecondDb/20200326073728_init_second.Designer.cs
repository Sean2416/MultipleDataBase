﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MultipleDataBase.EntityFrameworkCore;

namespace MultipleDataBase.Migrations.SecondDb
{
    [DbContext(typeof(SecondDbContext))]
    [Migration("20200326073728_init_second")]
    partial class init_second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MultipleDataBase.FirstDbEntities.FlowLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Act")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("DPort")
                        .HasColumnType("int");

                    b.Property<string>("DevID")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Dhost")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Dip")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("Down")
                        .HasColumnType("int");

                    b.Property<int?>("Proto")
                        .HasColumnType("int");

                    b.Property<string>("Sip")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("Sport")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Stime")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("Up")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Flow");
                });
#pragma warning restore 612, 618
        }
    }
}
