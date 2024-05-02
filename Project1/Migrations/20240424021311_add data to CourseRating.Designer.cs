﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project1.Data;

#nullable disable

namespace Project1.Migrations
{
    [DbContext(typeof(ProjectDbContext))]
    [Migration("20240424021311_add data to CourseRating")]
    partial class adddatatoCourseRating
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Project1.Models.ClassSchedule", b =>
                {
                    b.Property<int>("SchedulerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SchedulerID"));

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Scheduler")
                        .HasColumnType("datetime2");

                    b.HasKey("SchedulerID");

                    b.ToTable("ClassSchedule");
                });

            modelBuilder.Entity("Project1.Models.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseID"));

                    b.Property<string>("ApprovalStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Clicks")
                        .HasColumnType("int");

                    b.Property<string>("CourseCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DiscountID")
                        .HasColumnType("int");

                    b.Property<int?>("EnrollmentCount")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MaxParticipants")
                        .HasColumnType("int");

                    b.Property<string>("PetCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TrainerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("CourseID");

                    b.ToTable("Course");

                    b.HasData(
                        new
                        {
                            CourseID = 1,
                            ApprovalStatus = "通過",
                            Clicks = 21,
                            CourseCategory = "技能",
                            CourseName = "幼犬訓練",
                            CourseType = "一對一",
                            CreatedAt = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7943),
                            Description = "幼犬基本訓練",
                            DiscountID = 1,
                            EnrollmentCount = 0,
                            Location = "台北",
                            MaxParticipants = 1,
                            PetCategory = "狗",
                            Price = 100m,
                            TrainerID = 1,
                            UpdatedAt = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7944)
                        },
                        new
                        {
                            CourseID = 2,
                            ApprovalStatus = "通過",
                            Clicks = 21,
                            CourseCategory = "技能",
                            CourseName = "幼犬訓練",
                            CourseType = "一對一",
                            CreatedAt = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7947),
                            Description = "幼犬基本訓練",
                            DiscountID = 2,
                            EnrollmentCount = 0,
                            Location = "台北",
                            MaxParticipants = 1,
                            PetCategory = "狗",
                            Price = 100m,
                            TrainerID = 1,
                            UpdatedAt = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7947)
                        },
                        new
                        {
                            CourseID = 3,
                            ApprovalStatus = "通過",
                            Clicks = 21,
                            CourseCategory = "技能",
                            CourseName = "幼犬訓練",
                            CourseType = "一對一",
                            CreatedAt = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7950),
                            Description = "幼犬基本訓練",
                            DiscountID = 3,
                            EnrollmentCount = 0,
                            Location = "台北",
                            MaxParticipants = 1,
                            PetCategory = "狗",
                            Price = 100m,
                            TrainerID = 1,
                            UpdatedAt = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7950)
                        },
                        new
                        {
                            CourseID = 4,
                            ApprovalStatus = "通過",
                            Clicks = 21,
                            CourseCategory = "技能",
                            CourseName = "幼犬訓練",
                            CourseType = "一對一",
                            CreatedAt = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7952),
                            Description = "幼犬基本訓練",
                            DiscountID = 4,
                            EnrollmentCount = 0,
                            Location = "台北",
                            MaxParticipants = 1,
                            PetCategory = "狗",
                            Price = 100m,
                            TrainerID = 1,
                            UpdatedAt = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7952)
                        },
                        new
                        {
                            CourseID = 5,
                            ApprovalStatus = "通過",
                            Clicks = 21,
                            CourseCategory = "技能",
                            CourseName = "幼犬訓練",
                            CourseType = "一對一",
                            CreatedAt = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7956),
                            Description = "幼犬基本訓練",
                            DiscountID = 5,
                            EnrollmentCount = 0,
                            Location = "台北",
                            MaxParticipants = 1,
                            PetCategory = "狗",
                            Price = 100m,
                            TrainerID = 1,
                            UpdatedAt = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7956)
                        });
                });

            modelBuilder.Entity("Project1.Models.CourseRating", b =>
                {
                    b.Property<int>("CourseRatingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseRatingID"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime>("RatingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TrainerID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("CourseRatingID");

                    b.ToTable("CourseRating");

                    b.HasData(
                        new
                        {
                            CourseRatingID = 1,
                            Comment = "好學習",
                            CourseID = 1,
                            Rating = 5,
                            RatingDate = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7973),
                            TrainerID = 1,
                            UserID = 1
                        },
                        new
                        {
                            CourseRatingID = 2,
                            Comment = "好學習",
                            CourseID = 1,
                            Rating = 4,
                            RatingDate = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7974),
                            TrainerID = 1,
                            UserID = 3
                        },
                        new
                        {
                            CourseRatingID = 3,
                            Comment = "好學習",
                            CourseID = 1,
                            Rating = 3,
                            RatingDate = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7976),
                            TrainerID = 1,
                            UserID = 2
                        },
                        new
                        {
                            CourseRatingID = 4,
                            Comment = "好學習",
                            CourseID = 2,
                            Rating = 4,
                            RatingDate = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7977),
                            TrainerID = 1,
                            UserID = 1
                        },
                        new
                        {
                            CourseRatingID = 5,
                            Comment = "好學習",
                            CourseID = 2,
                            Rating = 5,
                            RatingDate = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7978),
                            TrainerID = 1,
                            UserID = 3
                        },
                        new
                        {
                            CourseRatingID = 6,
                            Comment = "好學習",
                            CourseID = 2,
                            Rating = 5,
                            RatingDate = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7979),
                            TrainerID = 1,
                            UserID = 2
                        },
                        new
                        {
                            CourseRatingID = 7,
                            Comment = "好學習",
                            CourseID = 3,
                            Rating = 5,
                            RatingDate = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7980),
                            TrainerID = 1,
                            UserID = 1
                        },
                        new
                        {
                            CourseRatingID = 8,
                            Comment = "好學習",
                            CourseID = 3,
                            Rating = 5,
                            RatingDate = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7981),
                            TrainerID = 1,
                            UserID = 3
                        },
                        new
                        {
                            CourseRatingID = 9,
                            Comment = "好學習",
                            CourseID = 3,
                            Rating = 3,
                            RatingDate = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7982),
                            TrainerID = 1,
                            UserID = 2
                        },
                        new
                        {
                            CourseRatingID = 10,
                            Comment = "好學習",
                            CourseID = 4,
                            Rating = 3,
                            RatingDate = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7983),
                            TrainerID = 1,
                            UserID = 1
                        },
                        new
                        {
                            CourseRatingID = 11,
                            Comment = "好學習",
                            CourseID = 4,
                            Rating = 3,
                            RatingDate = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7984),
                            TrainerID = 1,
                            UserID = 3
                        },
                        new
                        {
                            CourseRatingID = 12,
                            Comment = "好學習",
                            CourseID = 4,
                            Rating = 4,
                            RatingDate = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7985),
                            TrainerID = 1,
                            UserID = 2
                        },
                        new
                        {
                            CourseRatingID = 13,
                            Comment = "好學習",
                            CourseID = 5,
                            Rating = 5,
                            RatingDate = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7985),
                            TrainerID = 1,
                            UserID = 1
                        },
                        new
                        {
                            CourseRatingID = 14,
                            Comment = "好學習",
                            CourseID = 5,
                            Rating = 5,
                            RatingDate = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7986),
                            TrainerID = 1,
                            UserID = 3
                        },
                        new
                        {
                            CourseRatingID = 15,
                            Comment = "好學習",
                            CourseID = 5,
                            Rating = 5,
                            RatingDate = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7987),
                            TrainerID = 1,
                            UserID = 2
                        });
                });

            modelBuilder.Entity("Project1.Models.Discount", b =>
                {
                    b.Property<int>("DiscountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiscountID"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DiscountDESC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiscountName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DiscountPercentage")
                        .HasColumnType("float");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DiscountID");

                    b.ToTable("Discount");
                });

            modelBuilder.Entity("Project1.Models.Location", b =>
                {
                    b.Property<int>("LocationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocationID"));

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocationID");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("Project1.Models.Member", b =>
                {
                    b.Property<int>("MemberID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MemberID"));

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdministrator")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTrainer")
                        .HasColumnType("bit");

                    b.Property<string>("MemberType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ResidenceArea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MemberID");

                    b.ToTable("Member");
                });

            modelBuilder.Entity("Project1.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("MemberID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderID");

                    b.ToTable("Order");

                    b.HasData(
                        new
                        {
                            OrderID = 1,
                            CreatedAt = new DateTime(2024, 4, 24, 10, 13, 11, 39, DateTimeKind.Local).AddTicks(7884),
                            MemberID = 1,
                            OrderDate = new DateTime(2024, 4, 24, 10, 13, 11, 39, DateTimeKind.Local).AddTicks(7868),
                            OrderStatus = "Processing",
                            TotalAmount = 100m
                        },
                        new
                        {
                            OrderID = 2,
                            CreatedAt = new DateTime(2024, 4, 24, 10, 13, 11, 39, DateTimeKind.Local).AddTicks(7886),
                            MemberID = 2,
                            OrderDate = new DateTime(2024, 4, 24, 10, 13, 11, 39, DateTimeKind.Local).AddTicks(7885),
                            OrderStatus = "Delivered",
                            TotalAmount = 200m
                        },
                        new
                        {
                            OrderID = 3,
                            CreatedAt = new DateTime(2024, 4, 24, 10, 13, 11, 39, DateTimeKind.Local).AddTicks(7887),
                            MemberID = 3,
                            OrderDate = new DateTime(2024, 4, 24, 10, 13, 11, 39, DateTimeKind.Local).AddTicks(7887),
                            OrderStatus = "Cancelled",
                            TotalAmount = 300m
                        },
                        new
                        {
                            OrderID = 4,
                            CreatedAt = new DateTime(2024, 4, 24, 10, 13, 11, 39, DateTimeKind.Local).AddTicks(7889),
                            MemberID = 4,
                            OrderDate = new DateTime(2024, 4, 24, 10, 13, 11, 39, DateTimeKind.Local).AddTicks(7888),
                            OrderStatus = "Processing",
                            TotalAmount = 800m
                        },
                        new
                        {
                            OrderID = 5,
                            CreatedAt = new DateTime(2024, 4, 24, 10, 13, 11, 39, DateTimeKind.Local).AddTicks(7890),
                            MemberID = 5,
                            OrderDate = new DateTime(2024, 4, 24, 10, 13, 11, 39, DateTimeKind.Local).AddTicks(7890),
                            OrderStatus = "Shipped",
                            TotalAmount = 1000m
                        });
                });

            modelBuilder.Entity("Project1.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderDetailID"));

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DiscountID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderDetailID");

                    b.ToTable("OrderDetail");

                    b.HasData(
                        new
                        {
                            OrderDetailID = 1,
                            CourseID = 1,
                            CreatedAt = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7908),
                            DiscountID = 1,
                            OrderID = 1,
                            Quantity = 2,
                            UnitPrice = 100m
                        },
                        new
                        {
                            OrderDetailID = 2,
                            CourseID = 2,
                            CreatedAt = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7910),
                            DiscountID = 2,
                            OrderID = 1,
                            Quantity = 4,
                            UnitPrice = 100m
                        },
                        new
                        {
                            OrderDetailID = 3,
                            CourseID = 3,
                            CreatedAt = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7911),
                            DiscountID = 3,
                            OrderID = 1,
                            Quantity = 3,
                            UnitPrice = 100m
                        },
                        new
                        {
                            OrderDetailID = 4,
                            CourseID = 4,
                            CreatedAt = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7913),
                            DiscountID = 4,
                            OrderID = 2,
                            Quantity = 3,
                            UnitPrice = 100m
                        },
                        new
                        {
                            OrderDetailID = 5,
                            CourseID = 5,
                            CreatedAt = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7914),
                            DiscountID = 5,
                            OrderID = 2,
                            Quantity = 3,
                            UnitPrice = 100m
                        },
                        new
                        {
                            OrderDetailID = 6,
                            CourseID = 3,
                            CreatedAt = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7915),
                            DiscountID = 3,
                            OrderID = 2,
                            Quantity = 2,
                            UnitPrice = 100m
                        },
                        new
                        {
                            OrderDetailID = 7,
                            CourseID = 3,
                            CreatedAt = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7917),
                            DiscountID = 3,
                            OrderID = 3,
                            Quantity = 5,
                            UnitPrice = 100m
                        },
                        new
                        {
                            OrderDetailID = 8,
                            CourseID = 4,
                            CreatedAt = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7919),
                            DiscountID = 4,
                            OrderID = 3,
                            Quantity = 7,
                            UnitPrice = 100m
                        },
                        new
                        {
                            OrderDetailID = 9,
                            CourseID = 2,
                            CreatedAt = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7920),
                            DiscountID = 2,
                            OrderID = 4,
                            Quantity = 6,
                            UnitPrice = 100m
                        },
                        new
                        {
                            OrderDetailID = 10,
                            CourseID = 3,
                            CreatedAt = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7921),
                            DiscountID = 3,
                            OrderID = 4,
                            Quantity = 8,
                            UnitPrice = 100m
                        },
                        new
                        {
                            OrderDetailID = 11,
                            CourseID = 3,
                            CreatedAt = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7922),
                            DiscountID = 3,
                            OrderID = 4,
                            Quantity = 8,
                            UnitPrice = 100m
                        });
                });

            modelBuilder.Entity("Project1.Models.Payment", b =>
                {
                    b.Property<int>("PaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentID"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaymentID");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("Project1.Models.Pet", b =>
                {
                    b.Property<int>("PetID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PetID"));

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MemberID")
                        .HasColumnType("int");

                    b.Property<string>("PetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PetType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("PetID");

                    b.ToTable("Pet");
                });

            modelBuilder.Entity("Project1.Models.ShoppingCart", b =>
                {
                    b.Property<int>("CartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartID"));

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CartID");

                    b.ToTable("Cart");

                    b.HasData(
                        new
                        {
                            CartID = 1,
                            CourseID = 1,
                            CreatedAt = new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7785),
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("Project1.Models.Trainer", b =>
                {
                    b.Property<int>("TrainerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrainerID"));

                    b.Property<string>("Experience")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MemberID")
                        .HasColumnType("int");

                    b.Property<string>("Qualifications")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrainerID");

                    b.ToTable("Trainer");
                });

            modelBuilder.Entity("Project1.Models.TrainerServiceArea", b =>
                {
                    b.Property<int>("TeachingAreaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeachingAreaID"));

                    b.Property<int>("LocationID")
                        .HasColumnType("int");

                    b.Property<int>("TrainerID")
                        .HasColumnType("int");

                    b.HasKey("TeachingAreaID");

                    b.ToTable("TrainerServiceArea");
                });
#pragma warning restore 612, 618
        }
    }
}
