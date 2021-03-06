﻿// <auto-generated />
using System;
using HW3;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HW3.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HW3.Models.Forums", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ForumName");

                    b.Property<DateTime>("ForumTimeStamp");

                    b.HasKey("Id");

                    b.ToTable("HW3Forums");
                });

            modelBuilder.Entity("HW3.Models.Replies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Reply");

                    b.Property<int>("TopicId");

                    b.HasKey("Id");

                    b.ToTable("HW3Replies");
                });

            modelBuilder.Entity("HW3.Models.Topics", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ForumId");

                    b.Property<string>("TopicName");

                    b.Property<DateTime>("TopicTimeStamp");

                    b.HasKey("Id");

                    b.ToTable("HW3Topics");
                });
#pragma warning restore 612, 618
        }
    }
}
