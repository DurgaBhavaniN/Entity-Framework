﻿// <auto-generated />
using System;
using EFPractice.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFPractice.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFPractice.Models.Item", b =>
                {
                    b.Property<int>("Item_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Item_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int?>("Item_price")
                        .HasColumnType("int");

                    b.HasKey("Item_id");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("EFPractice.Models.Order", b =>
                {
                    b.Property<int>("Order_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DeliveryDate")
                        .HasColumnType("Date");

                    b.Property<int>("Item_Id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("Date");

                    b.HasKey("Order_id");

                    b.HasIndex("Item_Id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("EFPractice.Models.Order", b =>
                {
                    b.HasOne("EFPractice.Models.Item", "Item")
                        .WithMany("Orders")
                        .HasForeignKey("Item_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
