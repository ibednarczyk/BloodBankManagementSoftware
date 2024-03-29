﻿// <auto-generated />
using BloodBankManagementSoftware.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BloodBankManagementSoftware.Migrations
{
    [DbContext(typeof(MvcDonorContext))]
    partial class MvcDonorContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("BloodBankManagementSoftware.Models.Donor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("BloodGroup")
                        .HasColumnType("TEXT");

                    b.Property<string>("EMailAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("RequestId")
                        .HasColumnType("TEXT");

                    b.Property<char>("RhFactorType")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Donors");
                });
#pragma warning restore 612, 618
        }
    }
}
