﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using libraryProject.DataAccess.Context;

#nullable disable

namespace libraryProject.DataAccess.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("libraryProject.Entities.Models.Author", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Biography1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("libraryProject.Entities.Models.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AvailableCopies")
                        .HasColumnType("int");

                    b.Property<string>("BookISBN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("PubliserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ShelfId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TotalCopies")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PubliserId");

                    b.HasIndex("ShelfId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("libraryProject.Entities.Models.Loan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("LoanDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("RetrunDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Loans");
                });

            modelBuilder.Entity("libraryProject.Entities.Models.Publisher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublisherName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("libraryProject.Entities.Models.Shelf", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ShelfDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ShelftID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Shelfs");
                });

            modelBuilder.Entity("libraryProject.Entities.Models.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentSurname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("libraryProject.Entities.Models.Subject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SubjectName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("libraryProject.Entities.Models.Book", b =>
                {
                    b.HasOne("libraryProject.Entities.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId");

                    b.HasOne("libraryProject.Entities.Models.Publisher", "Publiser")
                        .WithMany("Book")
                        .HasForeignKey("PubliserId");

                    b.HasOne("libraryProject.Entities.Models.Shelf", "Shelf")
                        .WithMany("Book")
                        .HasForeignKey("ShelfId");

                    b.HasOne("libraryProject.Entities.Models.Subject", "Subject")
                        .WithMany("Book")
                        .HasForeignKey("SubjectId");

                    b.Navigation("Author");

                    b.Navigation("Publiser");

                    b.Navigation("Shelf");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("libraryProject.Entities.Models.Loan", b =>
                {
                    b.HasOne("libraryProject.Entities.Models.Student", "Student")
                        .WithMany("Loan")
                        .HasForeignKey("StudentId");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("libraryProject.Entities.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("libraryProject.Entities.Models.Publisher", b =>
                {
                    b.Navigation("Book");
                });

            modelBuilder.Entity("libraryProject.Entities.Models.Shelf", b =>
                {
                    b.Navigation("Book");
                });

            modelBuilder.Entity("libraryProject.Entities.Models.Student", b =>
                {
                    b.Navigation("Loan");
                });

            modelBuilder.Entity("libraryProject.Entities.Models.Subject", b =>
                {
                    b.Navigation("Book");
                });
#pragma warning restore 612, 618
        }
    }
}
