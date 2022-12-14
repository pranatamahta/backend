// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backend.DataModel;

#nullable disable

namespace backend.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221202174750_bpkb2")]
    partial class bpkb2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("backend.Model.Bpkb", b =>
                {
                    b.Property<string>("agreement_number")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("bpkb_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("bpkb_date_in")
                        .HasColumnType("datetime2");

                    b.Property<string>("bpkb_no")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("branch_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("faktur_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("faktur_no")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("location_id")
                        .HasColumnType("int");

                    b.Property<string>("police_no")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("agreement_number");

                    b.HasIndex("bpkb_no");

                    b.HasIndex("location_id");

                    b.ToTable("tr_bpkb");
                });

            modelBuilder.Entity("backend.Model.Location", b =>
                {
                    b.Property<int>("location_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("location_id"), 1L, 1);

                    b.Property<string>("location_name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("location_id");

                    b.HasIndex("location_name");

                    b.ToTable("ms_storage_location");
                });

            modelBuilder.Entity("backend.Model.Bpkb", b =>
                {
                    b.HasOne("backend.Model.Location", "ms_storage_location")
                        .WithMany()
                        .HasForeignKey("location_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ms_storage_location");
                });
#pragma warning restore 612, 618
        }
    }
}
