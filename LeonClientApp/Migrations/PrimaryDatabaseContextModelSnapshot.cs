﻿// <auto-generated />
using System;
using LeonCustomerTracker.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LeonClientApp.Migrations
{
    [DbContext(typeof(PrimaryDatabaseContext))]
    partial class PrimaryDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("LeonCustomerTracker.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("birthday")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("date_created")
                        .HasColumnType("TEXT");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("last_name")
                        .HasColumnType("TEXT");

                    b.Property<string>("notes")
                        .HasColumnType("TEXT");

                    b.Property<int>("rank")
                        .HasColumnType("INTEGER");

                    b.Property<int>("spending")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Client");
                });
#pragma warning restore 612, 618
        }
    }
}
