﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RetailTrack.Data;

#nullable disable

namespace RetailTrack.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241213224740_UpdateGoodsReceiptSchema")]
    partial class UpdateGoodsReceiptSchema
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("RetailTrack.Models.Movement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<decimal>("FinalPrice")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("MovementTypeId")
                        .HasColumnType("int");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("MovementTypeId");

                    b.HasIndex("ProductId");

                    b.ToTable("Movements");
                });

            modelBuilder.Entity("RetailTrack.Models.MovementType", b =>
                {
                    b.Property<int>("Movement_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Movement_Id"));

                    b.Property<string>("Movement_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Movement_Id");

                    b.ToTable("MovementTypes");
                });

            modelBuilder.Entity("RetailTrack.Models.PaymentMethod", b =>
                {
                    b.Property<int>("PaymentMethod_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("PaymentMethod_Id"));

                    b.Property<string>("PaymentMethod_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("PaymentMethod_Id");

                    b.ToTable("PaymentMethods");
                });

            modelBuilder.Entity("RetailTrack.Models.ProductSize", b =>
                {
                    b.Property<int>("Size_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Size_Id"));

                    b.Property<string>("Size_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Size_Id");

                    b.ToTable("ProductSizes");
                });

            modelBuilder.Entity("RetailTrack.Models.ProductStatus", b =>
                {
                    b.Property<int>("Status_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Status_Id"));

                    b.Property<string>("Status_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Status_Id");

                    b.ToTable("ProductStatuses");
                });

            modelBuilder.Entity("RetailTrack.Models.Products.Design", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<decimal>("Comision")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Designs");
                });

            modelBuilder.Entity("RetailTrack.Models.Products.GoodsReceipt", b =>
                {
                    b.Property<Guid>("ReceiptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("MaterialId")
                        .HasColumnType("char(36)");

                    b.Property<int>("PaymentMethodId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReceiptDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("ReceiptId");

                    b.HasIndex("MaterialId");

                    b.HasIndex("PaymentMethodId");

                    b.ToTable("GoodsReceipts");
                });

            modelBuilder.Entity("RetailTrack.Models.Products.GoodsReceiptDetail", b =>
                {
                    b.Property<Guid>("ReceiptId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("MaterialId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("DetailId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SizeId")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitCost")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("ReceiptId", "MaterialId");

                    b.HasIndex("MaterialId");

                    b.HasIndex("SizeId");

                    b.ToTable("GoodsReceiptDetails");
                });

            modelBuilder.Entity("RetailTrack.Models.Products.Material", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(65,30)");

                    b.Property<Guid>("MaterialTypeId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaterialTypeId");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("RetailTrack.Models.Products.MaterialType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("MaterialTypes");
                });

            modelBuilder.Entity("RetailTrack.Models.Products.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<Guid>("DesignId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("MaterialId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("ProductSizeId")
                        .HasColumnType("int");

                    b.Property<int>("ProductStatusId")
                        .HasColumnType("int");

                    b.Property<int>("QuantityRequested")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DesignId");

                    b.HasIndex("MaterialId");

                    b.HasIndex("ProductSizeId");

                    b.HasIndex("ProductStatusId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("RetailTrack.Models.Movement", b =>
                {
                    b.HasOne("RetailTrack.Models.MovementType", "Type")
                        .WithMany()
                        .HasForeignKey("MovementTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RetailTrack.Models.Products.Product", null)
                        .WithMany("Movements")
                        .HasForeignKey("ProductId");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("RetailTrack.Models.Products.GoodsReceipt", b =>
                {
                    b.HasOne("RetailTrack.Models.Products.Material", null)
                        .WithMany("GoodsReceipts")
                        .HasForeignKey("MaterialId");

                    b.HasOne("RetailTrack.Models.PaymentMethod", "PaymentMethod")
                        .WithMany()
                        .HasForeignKey("PaymentMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PaymentMethod");
                });

            modelBuilder.Entity("RetailTrack.Models.Products.GoodsReceiptDetail", b =>
                {
                    b.HasOne("RetailTrack.Models.Products.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RetailTrack.Models.Products.GoodsReceipt", "GoodsReceipt")
                        .WithMany("Details")
                        .HasForeignKey("ReceiptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RetailTrack.Models.ProductSize", "Size")
                        .WithMany()
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("GoodsReceipt");

                    b.Navigation("Material");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("RetailTrack.Models.Products.Material", b =>
                {
                    b.HasOne("RetailTrack.Models.Products.MaterialType", "MaterialType")
                        .WithMany("Materials")
                        .HasForeignKey("MaterialTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MaterialType");
                });

            modelBuilder.Entity("RetailTrack.Models.Products.Product", b =>
                {
                    b.HasOne("RetailTrack.Models.Products.Design", "Design")
                        .WithMany()
                        .HasForeignKey("DesignId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RetailTrack.Models.Products.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RetailTrack.Models.ProductSize", "Size")
                        .WithMany()
                        .HasForeignKey("ProductSizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RetailTrack.Models.ProductStatus", "Status")
                        .WithMany()
                        .HasForeignKey("ProductStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Design");

                    b.Navigation("Material");

                    b.Navigation("Size");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("RetailTrack.Models.Products.GoodsReceipt", b =>
                {
                    b.Navigation("Details");
                });

            modelBuilder.Entity("RetailTrack.Models.Products.Material", b =>
                {
                    b.Navigation("GoodsReceipts");
                });

            modelBuilder.Entity("RetailTrack.Models.Products.MaterialType", b =>
                {
                    b.Navigation("Materials");
                });

            modelBuilder.Entity("RetailTrack.Models.Products.Product", b =>
                {
                    b.Navigation("Movements");
                });
#pragma warning restore 612, 618
        }
    }
}
