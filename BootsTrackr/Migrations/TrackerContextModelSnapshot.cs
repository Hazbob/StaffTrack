﻿// <auto-generated />
using BootsTrackr.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BootsTrackr.Migrations
{
    [DbContext(typeof(TrackerContext))]
    partial class TrackerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.3.24172.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BootsTrackr.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("BootsTrackr.Models.Trackers.BaseTracker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("WeekOfYear")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("BaseTrackers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("BaseTracker");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("BootsTrackr.Models.Trackers.ATV", b =>
                {
                    b.HasBaseType("BootsTrackr.Models.Trackers.BaseTracker");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.HasIndex("EmployeeId");

                    b.HasDiscriminator().HasValue("ATV");
                });

            modelBuilder.Entity("BootsTrackr.Models.Trackers.FutureRenew", b =>
                {
                    b.HasBaseType("BootsTrackr.Models.Trackers.BaseTracker");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasIndex("EmployeeId");

                    b.HasDiscriminator().HasValue("FutureRenew");
                });

            modelBuilder.Entity("BootsTrackr.Models.Trackers.IPT", b =>
                {
                    b.HasBaseType("BootsTrackr.Models.Trackers.BaseTracker");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.HasIndex("EmployeeId");

                    b.ToTable("BaseTrackers", t =>
                        {
                            t.Property("Amount")
                                .HasColumnName("IPT_Amount");
                        });

                    b.HasDiscriminator().HasValue("IPT");
                });

            modelBuilder.Entity("BootsTrackr.Models.Trackers.PDS", b =>
                {
                    b.HasBaseType("BootsTrackr.Models.Trackers.BaseTracker");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasIndex("EmployeeId");

                    b.ToTable("BaseTrackers", t =>
                        {
                            t.Property("Quantity")
                                .HasColumnName("PDS_Quantity");
                        });

                    b.HasDiscriminator().HasValue("PDS");
                });

            modelBuilder.Entity("BootsTrackr.Models.Trackers.Sale", b =>
                {
                    b.HasBaseType("BootsTrackr.Models.Trackers.BaseTracker");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.HasIndex("EmployeeId");

                    b.ToTable("BaseTrackers", t =>
                        {
                            t.Property("Amount")
                                .HasColumnName("Sale_Amount");
                        });

                    b.HasDiscriminator().HasValue("Sale");
                });

            modelBuilder.Entity("BootsTrackr.Models.Trackers.ATV", b =>
                {
                    b.HasOne("BootsTrackr.Models.Employee", "Employee")
                        .WithMany("Atvs")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("BootsTrackr.Models.Trackers.FutureRenew", b =>
                {
                    b.HasOne("BootsTrackr.Models.Employee", "Employee")
                        .WithMany("FutureRenews")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("BootsTrackr.Models.Trackers.IPT", b =>
                {
                    b.HasOne("BootsTrackr.Models.Employee", "Employee")
                        .WithMany("Ipts")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("BootsTrackr.Models.Trackers.PDS", b =>
                {
                    b.HasOne("BootsTrackr.Models.Employee", "Employee")
                        .WithMany("Pdses")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("BootsTrackr.Models.Trackers.Sale", b =>
                {
                    b.HasOne("BootsTrackr.Models.Employee", "Employee")
                        .WithMany("Sales")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("BootsTrackr.Models.Employee", b =>
                {
                    b.Navigation("Atvs");

                    b.Navigation("FutureRenews");

                    b.Navigation("Ipts");

                    b.Navigation("Pdses");

                    b.Navigation("Sales");
                });
#pragma warning restore 612, 618
        }
    }
}
