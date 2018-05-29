﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using presurgeryapp.Models;
using System;

namespace presurgeryapp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180523004152_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

            modelBuilder.Entity("presurgeryapp.Models.Patient", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("firstname");

                    b.Property<string>("lastname");

                    b.Property<string>("phone");

                    b.Property<string>("surgeryDate");

                    b.HasKey("id");

                    b.ToTable("patients");
                });
#pragma warning restore 612, 618
        }
    }
}