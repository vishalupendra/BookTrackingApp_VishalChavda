﻿// <auto-generated />
using BookTrackingApp_VishalChavda.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookTrackingApp_VishalChavda.Migrations
{
    [DbContext(typeof(BookTrackingContext))]
    partial class BookTrackingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookCategoryType", b =>
                {
                    b.Property<string>("BooksISBN")
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("CategoryTypesType")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("BooksISBN", "CategoryTypesType");

                    b.HasIndex("CategoryTypesType");

                    b.ToTable("BookCategoryType");
                });

            modelBuilder.Entity("BookTrackingApp_VishalChavda.Models.Book", b =>
                {
                    b.Property<string>("ISBN")
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryNameToken")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NameToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.HasKey("ISBN");

                    b.HasIndex("CategoryNameToken");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BookTrackingApp_VishalChavda.Models.Category", b =>
                {
                    b.Property<string>("NameToken")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("NameToken");

                    b.HasIndex("Type");

                    b.ToTable("Categorys");
                });

            modelBuilder.Entity("BookTrackingApp_VishalChavda.Models.CategoryType", b =>
                {
                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("Type");

                    b.ToTable("CategoryTypes");
                });

            modelBuilder.Entity("BookCategoryType", b =>
                {
                    b.HasOne("BookTrackingApp_VishalChavda.Models.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksISBN")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookTrackingApp_VishalChavda.Models.CategoryType", null)
                        .WithMany()
                        .HasForeignKey("CategoryTypesType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookTrackingApp_VishalChavda.Models.Book", b =>
                {
                    b.HasOne("BookTrackingApp_VishalChavda.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryNameToken");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BookTrackingApp_VishalChavda.Models.Category", b =>
                {
                    b.HasOne("BookTrackingApp_VishalChavda.Models.CategoryType", "PrimaryCatType")
                        .WithMany("Categorys")
                        .HasForeignKey("Type");

                    b.Navigation("PrimaryCatType");
                });

            modelBuilder.Entity("BookTrackingApp_VishalChavda.Models.Category", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookTrackingApp_VishalChavda.Models.CategoryType", b =>
                {
                    b.Navigation("Categorys");
                });
#pragma warning restore 612, 618
        }
    }
}
