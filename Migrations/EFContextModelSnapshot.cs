﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using AspNetCoreDocker;

namespace aspnetcore_docker.Migrations
{
    [DbContext(typeof(EFContext))]
    partial class EFContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("AspNetCoreDocker.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Number");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("AspNetCoreDocker.Models.OrderItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<Guid>("OrderId");

                    b.Property<decimal>("Value");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrdersItems");
                });

            modelBuilder.Entity("AspNetCoreDocker.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AspNetCoreDocker.Models.OrderItem", b =>
                {
                    b.HasOne("AspNetCoreDocker.Models.Order")
                        .WithMany("Items")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
