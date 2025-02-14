﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MultipleDataBase.EntityFrameworkCore;

namespace MultipleDataBase.Migrations
{
    [DbContext(typeof(MultipleDataBaseDbContext))]
    [Migration("20200326073323_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MultipleDataBase.FirstDbEntities.Flow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Act")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DPort")
                        .HasColumnType("int");

                    b.Property<string>("DevID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dhost")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Down")
                        .HasColumnType("int");

                    b.Property<int?>("Proto")
                        .HasColumnType("int");

                    b.Property<string>("Sip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Sport")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Stime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Up")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Flow");
                });
#pragma warning restore 612, 618
        }
    }
}
