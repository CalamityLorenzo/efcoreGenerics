﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyDbApp;

namespace efcoreGenerics.Migrations
{
    [DbContext(typeof(DbAppContext))]
    [Migration("20200906114643_p3")]
    partial class p3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyDbApp.P1Core", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HostId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HostId");

                    b.ToTable("CoreOne");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            HostId = 2,
                            Name = "P1-Core 1"
                        },
                        new
                        {
                            Id = 2,
                            HostId = 2,
                            Name = "P1-Core 2"
                        });
                });

            modelBuilder.Entity("MyDbApp.P1Sub1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HostId")
                        .HasColumnType("int");

                    b.Property<int>("Numbers")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HostId");

                    b.ToTable("CoreOneS1");
                });

            modelBuilder.Entity("MyDbApp.P1Sub2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HostId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAOkay")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HostId");

                    b.ToTable("CoreOneS2");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            HostId = 1,
                            IsAOkay = false,
                            Name = "Matilda"
                        },
                        new
                        {
                            Id = 2,
                            HostId = 1,
                            IsAOkay = true,
                            Name = "Claming"
                        },
                        new
                        {
                            Id = 3,
                            HostId = 2,
                            IsAOkay = false,
                            Name = "Cujo"
                        });
                });

            modelBuilder.Entity("MyDbApp.P2Core", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HostId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HostId");

                    b.ToTable("CoreTwo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            HostId = 1,
                            Name = "P2-Core 1"
                        },
                        new
                        {
                            Id = 2,
                            HostId = 2,
                            Name = "P2-Core 2"
                        },
                        new
                        {
                            Id = 3,
                            HostId = 1,
                            Name = "P3-Core 2"
                        });
                });

            modelBuilder.Entity("MyDbApp.P2Sub2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HostId")
                        .HasColumnType("int");

                    b.Property<int>("Numbers")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HostId");

                    b.ToTable("CoreTwoS1");
                });

            modelBuilder.Entity("MyDbApp.P2SubOne", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HostId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAOkay")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HostId");

                    b.ToTable("CoreTwoS2");
                });

            modelBuilder.Entity("MyDbApp.ParentOne", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("NoTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("SameSame")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Selfish")
                        .HasColumnType("datetime2");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ParentOnes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NoTime = new DateTime(2020, 9, 3, 12, 46, 42, 105, DateTimeKind.Local).AddTicks(3763),
                            SameSame = "Not the usual",
                            Selfish = new DateTime(2020, 9, 6, 12, 46, 42, 102, DateTimeKind.Local).AddTicks(209),
                            Year = 1923
                        },
                        new
                        {
                            Id = 2,
                            NoTime = new DateTime(2020, 9, 6, 12, 46, 42, 105, DateTimeKind.Local).AddTicks(4767),
                            SameSame = "PLAAAAANK",
                            Selfish = new DateTime(2020, 9, 11, 12, 46, 42, 105, DateTimeKind.Local).AddTicks(4729),
                            Year = 1878
                        });
                });

            modelBuilder.Entity("MyDbApp.ParentTwo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("NoTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("PuffDaddy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SameSame")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ParentTwos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NoTime = new DateTime(2020, 9, 3, 12, 46, 42, 107, DateTimeKind.Local).AddTicks(4671),
                            PuffDaddy = "Is a parappa",
                            SameSame = "Another version"
                        },
                        new
                        {
                            Id = 2,
                            NoTime = new DateTime(2020, 9, 3, 12, 46, 42, 107, DateTimeKind.Local).AddTicks(5550),
                            PuffDaddy = "Pointiny",
                            SameSame = "Number two"
                        });
                });

            modelBuilder.Entity("MyDbApp.P1Core", b =>
                {
                    b.HasOne("MyDbApp.ParentOne", "Host")
                        .WithMany("CoreCollection")
                        .HasForeignKey("HostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyDbApp.P1Sub1", b =>
                {
                    b.HasOne("MyDbApp.P1Core", "Host")
                        .WithMany("SubsOne")
                        .HasForeignKey("HostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyDbApp.P1Sub2", b =>
                {
                    b.HasOne("MyDbApp.P1Core", "Host")
                        .WithMany("SubsTwo")
                        .HasForeignKey("HostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyDbApp.P2Core", b =>
                {
                    b.HasOne("MyDbApp.ParentTwo", "Host")
                        .WithMany("CoreCollection")
                        .HasForeignKey("HostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyDbApp.P2Sub2", b =>
                {
                    b.HasOne("MyDbApp.P2Core", "Host")
                        .WithMany("SubsOne")
                        .HasForeignKey("HostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyDbApp.P2SubOne", b =>
                {
                    b.HasOne("MyDbApp.P2Core", "Host")
                        .WithMany("SubsTwo")
                        .HasForeignKey("HostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}