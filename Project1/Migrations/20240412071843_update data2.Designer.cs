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
    [Migration("20240412071843_update data2")]
    partial class updatedata2
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
                            CreatedAt = new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8900),
                            Description = "幼犬基本訓練",
                            DiscountID = 1,
                            EnrollmentCount = 0,
                            Location = "台北",
                            MaxParticipants = 1,
                            PetCategory = "狗",
                            Price = 100m,
                            TrainerID = 1,
                            UpdatedAt = new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8901)
                        },
                        new
                        {
                            CourseID = 2,
                            ApprovalStatus = "通過",
                            Clicks = 21,
                            CourseCategory = "技能",
                            CourseName = "幼犬訓練",
                            CourseType = "一對一",
                            CreatedAt = new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8904),
                            Description = "幼犬基本訓練",
                            DiscountID = 2,
                            EnrollmentCount = 0,
                            Location = "台北",
                            MaxParticipants = 1,
                            PetCategory = "狗",
                            Price = 100m,
                            TrainerID = 1,
                            UpdatedAt = new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8904)
                        },
                        new
                        {
                            CourseID = 3,
                            ApprovalStatus = "通過",
                            Clicks = 21,
                            CourseCategory = "技能",
                            CourseName = "幼犬訓練",
                            CourseType = "一對一",
                            CreatedAt = new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8906),
                            Description = "幼犬基本訓練",
                            DiscountID = 3,
                            EnrollmentCount = 0,
                            Location = "台北",
                            MaxParticipants = 1,
                            PetCategory = "狗",
                            Price = 100m,
                            TrainerID = 1,
                            UpdatedAt = new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8907)
                        },
                        new
                        {
                            CourseID = 4,
                            ApprovalStatus = "通過",
                            Clicks = 21,
                            CourseCategory = "技能",
                            CourseName = "幼犬訓練",
                            CourseType = "一對一",
                            CreatedAt = new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8909),
                            Description = "幼犬基本訓練",
                            DiscountID = 4,
                            EnrollmentCount = 0,
                            Location = "台北",
                            MaxParticipants = 1,
                            PetCategory = "狗",
                            Price = 100m,
                            TrainerID = 1,
                            UpdatedAt = new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8909)
                        },
                        new
                        {
                            CourseID = 5,
                            ApprovalStatus = "通過",
                            Clicks = 21,
                            CourseCategory = "技能",
                            CourseName = "幼犬訓練",
                            CourseType = "一對一",
                            CreatedAt = new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8956),
                            Description = "幼犬基本訓練",
                            DiscountID = 5,
                            EnrollmentCount = 0,
                            Location = "台北",
                            MaxParticipants = 1,
                            PetCategory = "狗",
                            Price = 100m,
                            TrainerID = 1,
                            UpdatedAt = new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8956)
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
                            CreatedAt = new DateTime(2024, 4, 12, 15, 18, 43, 423, DateTimeKind.Local).AddTicks(8840),
                            MemberID = 1,
                            OrderDate = new DateTime(2024, 4, 12, 15, 18, 43, 423, DateTimeKind.Local).AddTicks(8827),
                            OrderStatus = "Processing",
                            TotalAmount = 100m
                        },
                        new
                        {
                            OrderID = 2,
                            CreatedAt = new DateTime(2024, 4, 12, 15, 18, 43, 423, DateTimeKind.Local).AddTicks(8842),
                            MemberID = 2,
                            OrderDate = new DateTime(2024, 4, 12, 15, 18, 43, 423, DateTimeKind.Local).AddTicks(8841),
                            OrderStatus = "Delivered",
                            TotalAmount = 200m
                        },
                        new
                        {
                            OrderID = 3,
                            CreatedAt = new DateTime(2024, 4, 12, 15, 18, 43, 423, DateTimeKind.Local).AddTicks(8844),
                            MemberID = 3,
                            OrderDate = new DateTime(2024, 4, 12, 15, 18, 43, 423, DateTimeKind.Local).AddTicks(8843),
                            OrderStatus = "Cancelled",
                            TotalAmount = 300m
                        },
                        new
                        {
                            OrderID = 4,
                            CreatedAt = new DateTime(2024, 4, 12, 15, 18, 43, 423, DateTimeKind.Local).AddTicks(8845),
                            MemberID = 4,
                            OrderDate = new DateTime(2024, 4, 12, 15, 18, 43, 423, DateTimeKind.Local).AddTicks(8844),
                            OrderStatus = "Processing",
                            TotalAmount = 800m
                        },
                        new
                        {
                            OrderID = 5,
                            CreatedAt = new DateTime(2024, 4, 12, 15, 18, 43, 423, DateTimeKind.Local).AddTicks(8846),
                            MemberID = 5,
                            OrderDate = new DateTime(2024, 4, 12, 15, 18, 43, 423, DateTimeKind.Local).AddTicks(8846),
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
                            CreatedAt = new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8866),
                            DiscountID = 1,
                            OrderID = 1,
                            Quantity = 2,
                            UnitPrice = 100m
                        },
                        new
                        {
                            OrderDetailID = 2,
                            CourseID = 2,
                            CreatedAt = new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8867),
                            DiscountID = 2,
                            OrderID = 1,
                            Quantity = 4,
                            UnitPrice = 100m
                        },
                        new
                        {
                            OrderDetailID = 3,
                            CourseID = 3,
                            CreatedAt = new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8869),
                            DiscountID = 3,
                            OrderID = 1,
                            Quantity = 3,
                            UnitPrice = 100m
                        },
                        new
                        {
                            OrderDetailID = 4,
                            CourseID = 4,
                            CreatedAt = new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8870),
                            DiscountID = 4,
                            OrderID = 2,
                            Quantity = 3,
                            UnitPrice = 100m
                        },
                        new
                        {
                            OrderDetailID = 5,
                            CourseID = 5,
                            CreatedAt = new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8871),
                            DiscountID = 5,
                            OrderID = 2,
                            Quantity = 3,
                            UnitPrice = 100m
                        },
                        new
                        {
                            OrderDetailID = 6,
                            CourseID = 3,
                            CreatedAt = new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8872),
                            DiscountID = 3,
                            OrderID = 2,
                            Quantity = 2,
                            UnitPrice = 100m
                        },
                        new
                        {
                            OrderDetailID = 7,
                            CourseID = 3,
                            CreatedAt = new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8874),
                            DiscountID = 3,
                            OrderID = 3,
                            Quantity = 5,
                            UnitPrice = 100m
                        },
                        new
                        {
                            OrderDetailID = 8,
                            CourseID = 4,
                            CreatedAt = new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8875),
                            DiscountID = 4,
                            OrderID = 3,
                            Quantity = 7,
                            UnitPrice = 100m
                        },
                        new
                        {
                            OrderDetailID = 9,
                            CourseID = 2,
                            CreatedAt = new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8877),
                            DiscountID = 2,
                            OrderID = 4,
                            Quantity = 6,
                            UnitPrice = 100m
                        },
                        new
                        {
                            OrderDetailID = 10,
                            CourseID = 3,
                            CreatedAt = new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8878),
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
                            CreatedAt = new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8747),
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