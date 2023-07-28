﻿// <auto-generated />
using System;
using LoginRegisterApp.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LoginRegisterApp.Migrations.Showcase
{
    [DbContext(typeof(ShowcaseContext))]
    [Migration("20230719102700_ShowcaseMigration")]
    partial class ShowcaseMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LoginRegisterApp.Models.Showcases", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsItMını")
                        .HasColumnType("bit");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShowcaseHeader")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShowcasePhotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShowcaseText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShowcaseUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("showcases");
                });
#pragma warning restore 612, 618
        }
    }
}
