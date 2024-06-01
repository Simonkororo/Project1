using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class removehasDataOrderDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4100), new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4103) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4106), new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4107) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4110), new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4113), new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4113) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4116), new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4116) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4118), new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4119) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4121), new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4121) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4124), new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4124) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4126), new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4127) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4131), new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4131) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4134), new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4134) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4136), new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4137) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4139), new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4142), new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4142) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4145), new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4145) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 10, 6, 19, 281, DateTimeKind.Utc).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 1, 18, 6, 19, 281, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 1, 18, 6, 19, 281, DateTimeKind.Local).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 1, 18, 6, 19, 281, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 1, 18, 6, 19, 281, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 1, 18, 6, 19, 281, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 1, 18, 6, 19, 281, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 1, 18, 6, 19, 281, DateTimeKind.Local).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 1, 18, 6, 19, 281, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 1, 18, 6, 19, 281, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 1, 18, 6, 19, 281, DateTimeKind.Local).AddTicks(4372));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9312), new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9313) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9316), new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9316) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9319), new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9319) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9322), new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9322) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9325), new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9325) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9328), new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9330), new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9333), new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9336), new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9338), new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9339) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9341), new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9341) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9344), new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9344) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9346), new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9349), new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9349) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9352), new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9352) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9452));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderID", "CreatedAt", "DiscountID", "MemberID", "MerchantTradeNo", "ModifiedAt", "OrderDate", "OrderStatus", "TotalAmount" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9082), null, 1, null, null, new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9072), "Processing", 100m },
                    { 2, new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9084), null, 2, null, null, new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9083), "Delivered", 200m },
                    { 3, new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9086), null, 3, null, null, new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9086), "Cancelled", 300m },
                    { 4, new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9088), null, 4, null, null, new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9088), "Processing", 800m },
                    { 5, new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9090), null, 5, null, null, new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9090), "Shipped", 1000m }
                });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "OrderDetailID", "CourseID", "CreatedAt", "ModifiedAt", "OrderID", "Quantity", "SchedulerID", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9221), null, 1, 2, null, 100m },
                    { 2, 2, new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9223), null, 1, 4, null, 100m },
                    { 3, 3, new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9225), null, 1, 3, null, 100m },
                    { 4, 4, new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9226), null, 2, 3, null, 100m },
                    { 5, 5, new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9228), null, 2, 3, null, 100m },
                    { 6, 3, new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9229), null, 2, 2, null, 100m },
                    { 7, 3, new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9230), null, 3, 5, null, 100m },
                    { 8, 4, new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9232), null, 3, 7, null, 100m },
                    { 9, 2, new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9233), null, 4, 6, null, 100m },
                    { 10, 3, new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9235), null, 4, 8, null, 100m },
                    { 11, 3, new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9236), null, 4, 8, null, 100m }
                });
        }
    }
}
