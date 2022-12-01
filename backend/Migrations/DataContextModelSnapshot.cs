﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backend.DataModel;

namespace backend.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("backend.Model.Bpkb", b =>
                {
                    b.Property<string>("agreement_number")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("bpkb_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("bpkb_date_in")
                        .HasColumnType("datetime2");

                    b.Property<string>("bpkb_no")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("branch_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("faktur_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("faktur_no")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("location_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("police_no")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("agreement_number");

                    b.HasIndex("location_id");

                    b.ToTable("tr_bpkb");
                });

            modelBuilder.Entity("backend.Model.Location", b =>
                {
                    b.Property<string>("location_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("location_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("location_id");

                    b.ToTable("ms_storage_location");
                });

            modelBuilder.Entity("backend.Model.Bpkb", b =>
                {
                    b.HasOne("backend.Model.Location", "ms_storage_location")
                        .WithMany()
                        .HasForeignKey("location_id");
                });
#pragma warning restore 612, 618
        }
    }
}
