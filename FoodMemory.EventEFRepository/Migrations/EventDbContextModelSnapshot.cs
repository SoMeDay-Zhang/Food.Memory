﻿// <auto-generated />
using System;
using FoodMemory.EventEFRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoodMemory.EventEFRepository.Migrations
{
    [DbContext(typeof(EventDbContext))]
    partial class EventDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FoodMemory.EventEFRepository.MsSqlMetadata.MetadataContainer", b =>
                {
                    b.Property<Guid>("EventId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AggregateId");

                    b.Property<string>("AggregateName")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<long>("AggregateVersion");

                    b.Property<DateTime>("CreatedTime");

                    b.Property<byte[]>("Data")
                        .IsRequired();

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<long>("EventVersion");

                    b.HasKey("EventId");

                    b.ToTable("MetadataContainers");
                });
#pragma warning restore 612, 618
        }
    }
}
