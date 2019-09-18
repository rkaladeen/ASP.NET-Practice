﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Service.Models;

namespace Service.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Service.LikeModel", b =>
                {
                    b.Property<int>("Like_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ArticleNews_Id");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int?>("User_Id");

                    b.HasKey("Like_Id");

                    b.HasIndex("ArticleNews_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("Service.Models.NewsCategoryModel", b =>
                {
                    b.Property<int>("Category_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Category_Id");

                    b.ToTable("NewsCategorys");
                });

            modelBuilder.Entity("Service.Models.NewsModel", b =>
                {
                    b.Property<int>("News_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AuthorUser_Id");

                    b.Property<int>("Category_Id");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Img_Url")
                        .IsRequired();

                    b.Property<string>("SubTitle")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("News_Id");

                    b.HasIndex("AuthorUser_Id");

                    b.HasIndex("Category_Id");

                    b.ToTable("News");
                });

            modelBuilder.Entity("Service.Models.StoreModel", b =>
                {
                    b.Property<int>("Store_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("GeneralManagerUser_Id");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("OTPUser_Id");

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<string>("StreetAddress")
                        .IsRequired();

                    b.Property<int>("SupervisorUser_Id");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("Zip")
                        .HasMaxLength(5);

                    b.HasKey("Store_Id");

                    b.HasIndex("GeneralManagerUser_Id");

                    b.HasIndex("OTPUser_Id");

                    b.HasIndex("SupervisorUser_Id");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("Service.Models.TicketModel", b =>
                {
                    b.Property<int>("Ticket_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Assigned_User_Id");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<int>("Location_Id");

                    b.Property<string>("Priority");

                    b.Property<int>("Reporter_Id");

                    b.Property<string>("Resolution")
                        .HasMaxLength(1000);

                    b.Property<string>("Status");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Ticket_Id");

                    b.HasIndex("Assigned_User_Id");

                    b.HasIndex("Location_Id");

                    b.HasIndex("Reporter_Id");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Service.Models.UserModel", b =>
                {
                    b.Property<int>("User_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("User_Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Service.LikeModel", b =>
                {
                    b.HasOne("Service.Models.NewsModel", "Article")
                        .WithMany("Liked_By")
                        .HasForeignKey("ArticleNews_Id");

                    b.HasOne("Service.Models.UserModel", "User")
                        .WithMany()
                        .HasForeignKey("User_Id");
                });

            modelBuilder.Entity("Service.Models.NewsModel", b =>
                {
                    b.HasOne("Service.Models.UserModel", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorUser_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Service.Models.NewsCategoryModel", "Category")
                        .WithMany()
                        .HasForeignKey("Category_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Service.Models.StoreModel", b =>
                {
                    b.HasOne("Service.Models.UserModel", "GeneralManager")
                        .WithMany()
                        .HasForeignKey("GeneralManagerUser_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Service.Models.UserModel", "OTP")
                        .WithMany()
                        .HasForeignKey("OTPUser_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Service.Models.UserModel", "Supervisor")
                        .WithMany()
                        .HasForeignKey("SupervisorUser_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Service.Models.TicketModel", b =>
                {
                    b.HasOne("Service.Models.UserModel", "Assigned_To")
                        .WithMany()
                        .HasForeignKey("Assigned_User_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Service.Models.StoreModel", "Location")
                        .WithMany()
                        .HasForeignKey("Location_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Service.Models.UserModel", "Reported_By")
                        .WithMany()
                        .HasForeignKey("Reporter_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
