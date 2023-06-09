﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Todo_List_KH.AppContext;

namespace Todo_List_KH.Migrations
{
    [DbContext(typeof(WebAppContext))]
    [Migration("20230328084835_changeTableNameAndSeedData")]
    partial class changeTableNameAndSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Todo_List_KH.Models.ToDoItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ExecutionTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("ToDoItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ExecutionTime = new DateTime(2023, 3, 28, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Name = "Podlać kwiaty"
                        },
                        new
                        {
                            Id = 2,
                            ExecutionTime = new DateTime(2023, 3, 28, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Name = "Zjeść obiad"
                        },
                        new
                        {
                            Id = 3,
                            ExecutionTime = new DateTime(2023, 3, 28, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Name = "Wyprowadzić psa na spacer"
                        },
                        new
                        {
                            Id = 4,
                            ExecutionTime = new DateTime(2023, 3, 28, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Name = "Zrobić zakupy"
                        },
                        new
                        {
                            Id = 5,
                            ExecutionTime = new DateTime(2023, 3, 28, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Name = "Zjeść kolację"
                        },
                        new
                        {
                            Id = 6,
                            ExecutionTime = new DateTime(2023, 3, 29, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Name = "Podlać kwiaty"
                        },
                        new
                        {
                            Id = 7,
                            ExecutionTime = new DateTime(2023, 3, 29, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Name = "Zjeść obiad"
                        },
                        new
                        {
                            Id = 8,
                            ExecutionTime = new DateTime(2023, 3, 29, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Name = "Wyprowadzić psa na spacer"
                        },
                        new
                        {
                            Id = 9,
                            ExecutionTime = new DateTime(2023, 3, 29, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Name = "Zrobić zakupy"
                        },
                        new
                        {
                            Id = 10,
                            ExecutionTime = new DateTime(2023, 3, 29, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Name = "Zjeść kolację"
                        },
                        new
                        {
                            Id = 11,
                            ExecutionTime = new DateTime(2023, 3, 30, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Name = "Podlać kwiaty"
                        },
                        new
                        {
                            Id = 12,
                            ExecutionTime = new DateTime(2023, 3, 30, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Name = "Zjeść obiad"
                        },
                        new
                        {
                            Id = 13,
                            ExecutionTime = new DateTime(2023, 3, 30, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Name = "Wyprowadzić psa na spacer"
                        },
                        new
                        {
                            Id = 14,
                            ExecutionTime = new DateTime(2023, 3, 30, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Name = "Zrobić zakupy"
                        },
                        new
                        {
                            Id = 15,
                            ExecutionTime = new DateTime(2023, 3, 30, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Name = "Zjeść kolację"
                        },
                        new
                        {
                            Id = 16,
                            ExecutionTime = new DateTime(2023, 3, 31, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Name = "Podlać kwiaty"
                        },
                        new
                        {
                            Id = 17,
                            ExecutionTime = new DateTime(2023, 3, 31, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Name = "Zjeść obiad"
                        },
                        new
                        {
                            Id = 18,
                            ExecutionTime = new DateTime(2023, 3, 31, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Name = "Wyprowadzić psa na spacer"
                        },
                        new
                        {
                            Id = 19,
                            ExecutionTime = new DateTime(2023, 3, 31, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Name = "Zrobić zakupy"
                        },
                        new
                        {
                            Id = 20,
                            ExecutionTime = new DateTime(2023, 3, 31, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Name = "Zjeść kolację"
                        },
                        new
                        {
                            Id = 21,
                            ExecutionTime = new DateTime(2023, 4, 1, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Name = "Podlać kwiaty"
                        },
                        new
                        {
                            Id = 22,
                            ExecutionTime = new DateTime(2023, 4, 1, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Name = "Zjeść obiad"
                        },
                        new
                        {
                            Id = 23,
                            ExecutionTime = new DateTime(2023, 4, 1, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Name = "Wyprowadzić psa na spacer"
                        },
                        new
                        {
                            Id = 24,
                            ExecutionTime = new DateTime(2023, 4, 1, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Name = "Zrobić zakupy"
                        },
                        new
                        {
                            Id = 25,
                            ExecutionTime = new DateTime(2023, 4, 1, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Name = "Zjeść kolację"
                        },
                        new
                        {
                            Id = 26,
                            ExecutionTime = new DateTime(2023, 4, 2, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Name = "Podlać kwiaty"
                        },
                        new
                        {
                            Id = 27,
                            ExecutionTime = new DateTime(2023, 4, 2, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Name = "Zjeść obiad"
                        },
                        new
                        {
                            Id = 28,
                            ExecutionTime = new DateTime(2023, 4, 2, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Name = "Wyprowadzić psa na spacer"
                        },
                        new
                        {
                            Id = 29,
                            ExecutionTime = new DateTime(2023, 4, 2, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Name = "Zrobić zakupy"
                        },
                        new
                        {
                            Id = 30,
                            ExecutionTime = new DateTime(2023, 4, 2, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Name = "Zjeść kolację"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
