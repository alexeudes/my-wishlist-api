﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using my_wishlist_api.Context;

#nullable disable

namespace mywishlistapi.Migrations
{
    [DbContext(typeof(MyWishlistDbContext))]
    [Migration("20221231005747_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("my_wishlist_api.Models.Wishlist", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateOfDesire")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<byte>("Photo")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("Priority")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SourceOfBuy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Wishlists");
                });
#pragma warning restore 612, 618
        }
    }
}
