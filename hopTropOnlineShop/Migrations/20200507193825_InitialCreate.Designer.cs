﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using hopTropOnlineShop.DAL;

namespace hopTropOnlineShop.Migrations
{
    [DbContext(typeof(OnlineShopContext))]
    [Migration("20200507193825_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("hopTropOnlineShop.Models.Basket", b =>
                {
                    b.Property<int>("IDBasket")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CustomerIDCustomer")
                        .HasColumnType("int");

                    b.Property<int>("IDCustomer")
                        .HasColumnType("int");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDBasket");

                    b.HasIndex("CustomerIDCustomer");

                    b.ToTable("Basket");
                });

            modelBuilder.Entity("hopTropOnlineShop.Models.Cloth", b =>
                {
                    b.Property<int>("IDCloth")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeOfCloth")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDCloth");

                    b.ToTable("Cloth");
                });

            modelBuilder.Entity("hopTropOnlineShop.Models.Customer", b =>
                {
                    b.Property<int>("IDCustomer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelephoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDCustomer");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("hopTropOnlineShop.Models.Delivery", b =>
                {
                    b.Property<int>("IdDelivery")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeliveryDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IDOrder")
                        .HasColumnType("int");

                    b.HasKey("IdDelivery");

                    b.ToTable("Delivery");
                });

            modelBuilder.Entity("hopTropOnlineShop.Models.Order", b =>
                {
                    b.Property<int>("IDOrder")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdBasket")
                        .HasColumnType("int");

                    b.Property<double>("Sum")
                        .HasColumnType("float");

                    b.HasKey("IDOrder");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("hopTropOnlineShop.Models.WishListCloth", b =>
                {
                    b.Property<int>("IDCloth")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BasketIDBasket")
                        .HasColumnType("int");

                    b.Property<int?>("ClothIDCloth")
                        .HasColumnType("int");

                    b.Property<int>("IDBasket")
                        .HasColumnType("int");

                    b.HasKey("IDCloth");

                    b.HasIndex("BasketIDBasket");

                    b.HasIndex("ClothIDCloth");

                    b.ToTable("WishListCloth");
                });

            modelBuilder.Entity("hopTropOnlineShop.Models.Basket", b =>
                {
                    b.HasOne("hopTropOnlineShop.Models.Customer", null)
                        .WithMany("Baskets")
                        .HasForeignKey("CustomerIDCustomer");
                });

            modelBuilder.Entity("hopTropOnlineShop.Models.WishListCloth", b =>
                {
                    b.HasOne("hopTropOnlineShop.Models.Basket", null)
                        .WithMany("WishListClothes")
                        .HasForeignKey("BasketIDBasket");

                    b.HasOne("hopTropOnlineShop.Models.Cloth", null)
                        .WithMany("WishListClothes")
                        .HasForeignKey("ClothIDCloth");
                });
#pragma warning restore 612, 618
        }
    }
}