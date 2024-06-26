﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Short_It.Data;

#nullable disable

namespace Short_It.Migrations
{
    [DbContext(typeof(ShortItAppContext))]
    partial class ShortItAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("Short_It.Models.Link", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("FullLink")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LinkTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ShortLink")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TimesVisited")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Links");
                });
#pragma warning restore 612, 618
        }
    }
}
