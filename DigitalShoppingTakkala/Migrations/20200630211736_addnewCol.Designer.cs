﻿// <auto-generated />
using System;
using DigitalShoppingTakkala.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DigitalShoppingTakkala.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20200630211736_addnewCol")]
    partial class addnewCol
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DigitalShoppingTakkala.Models.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("BrandId");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("DigitalShoppingTakkala.Models.Comment", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentText")
                        .IsRequired();

                    b.Property<int>("ProductId");

                    b.Property<int>("Score");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.HasKey("CommentID");

                    b.HasIndex("ProductId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("DigitalShoppingTakkala.Models.Customers", b =>
                {
                    b.Property<int>("CusId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("address")
                        .IsRequired();

                    b.Property<string>("gender");

                    b.Property<string>("lastname")
                        .IsRequired();

                    b.Property<string>("name")
                        .IsRequired();

                    b.Property<string>("province")
                        .IsRequired();

                    b.Property<string>("user")
                        .IsRequired();

                    b.HasKey("CusId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("DigitalShoppingTakkala.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.HasKey("GroupId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("DigitalShoppingTakkala.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<int>("CusId");

                    b.Property<bool>("IsFinally");

                    b.Property<double>("Sum");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("OrderId");

                    b.HasIndex("CusId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DigitalShoppingTakkala.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count");

                    b.Property<double>("FinalPrice");

                    b.Property<int>("OrderId");

                    b.Property<int>("ProductId");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("DigitalShoppingTakkala.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId");

                    b.Property<string>("Colors")
                        .IsRequired();

                    b.Property<string>("ImageName")
                        .IsRequired();

                    b.Property<double>("Price");

                    b.Property<double>("Price2");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<int>("SubGroupId");

                    b.Property<string>("TotalDescription")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<int>("instock");

                    b.Property<int>("introduceyear");

                    b.Property<int>("mass");

                    b.Property<string>("size");

                    b.Property<int>("status");

                    b.HasKey("ProductId");

                    b.HasIndex("BrandId");

                    b.HasIndex("SubGroupId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DigitalShoppingTakkala.Models.SubGroup", b =>
                {
                    b.Property<int>("SubGroupId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GroupId");

                    b.Property<string>("SubGroupName")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.HasKey("SubGroupId");

                    b.HasIndex("GroupId");

                    b.ToTable("SubGroups");
                });

            modelBuilder.Entity("DigitalShoppingTakkala.Models.Comment", b =>
                {
                    b.HasOne("DigitalShoppingTakkala.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DigitalShoppingTakkala.Models.Order", b =>
                {
                    b.HasOne("DigitalShoppingTakkala.Models.Customers", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CusId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DigitalShoppingTakkala.Models.OrderDetail", b =>
                {
                    b.HasOne("DigitalShoppingTakkala.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DigitalShoppingTakkala.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DigitalShoppingTakkala.Models.Product", b =>
                {
                    b.HasOne("DigitalShoppingTakkala.Models.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DigitalShoppingTakkala.Models.SubGroup", "SubGroup")
                        .WithMany("products")
                        .HasForeignKey("SubGroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DigitalShoppingTakkala.Models.SubGroup", b =>
                {
                    b.HasOne("DigitalShoppingTakkala.Models.Group", "Group")
                        .WithMany("subGroups")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
