using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class ModifyMembercs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Account",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Member");

            migrationBuilder.AlterColumn<bool>(
                name: "IsAdministrator",
                table: "Member",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.CreateTable(
                name: "FollowItem",
                columns: table => new
                {
                    FollowItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    MemberID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FollowItem", x => x.FollowItemId);
                });

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2168), new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2174), new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2177), new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2179), new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2182), new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2184), new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2184) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2186), new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2187) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2190), new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2191) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2193), new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2194) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2196), new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2198), new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2201), new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2203), new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2207), new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2210), new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2246));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2289));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 27, 22, 46, 45, 340, DateTimeKind.Local).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 27, 22, 46, 45, 340, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 27, 22, 46, 45, 340, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 27, 22, 46, 45, 340, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 27, 22, 46, 45, 340, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 27, 22, 46, 45, 340, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 27, 22, 46, 45, 340, DateTimeKind.Local).AddTicks(2342));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 27, 22, 46, 45, 340, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 27, 22, 46, 45, 340, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 27, 22, 46, 45, 340, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 27, 22, 46, 45, 340, DateTimeKind.Local).AddTicks(2087), new DateTime(2024, 5, 27, 22, 46, 45, 340, DateTimeKind.Local).AddTicks(2076) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 27, 22, 46, 45, 340, DateTimeKind.Local).AddTicks(2090), new DateTime(2024, 5, 27, 22, 46, 45, 340, DateTimeKind.Local).AddTicks(2089) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 27, 22, 46, 45, 340, DateTimeKind.Local).AddTicks(2091), new DateTime(2024, 5, 27, 22, 46, 45, 340, DateTimeKind.Local).AddTicks(2091) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 27, 22, 46, 45, 340, DateTimeKind.Local).AddTicks(2093), new DateTime(2024, 5, 27, 22, 46, 45, 340, DateTimeKind.Local).AddTicks(2093) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 27, 22, 46, 45, 340, DateTimeKind.Local).AddTicks(2095), new DateTime(2024, 5, 27, 22, 46, 45, 340, DateTimeKind.Local).AddTicks(2094) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 14, 46, 45, 340, DateTimeKind.Utc).AddTicks(2135));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FollowItem");

            migrationBuilder.AlterColumn<bool>(
                name: "IsAdministrator",
                table: "Member",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Account",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7166), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7166) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7188), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7191), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7191) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7194), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7196), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7199), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7199) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7201), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7204), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7204) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7207), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7207) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7209), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7209) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7211), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7212) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7214), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7216), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7216) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7218), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7221), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                columns: new[] { "Account", "Password", "RegistrationDate" },
                values: new object[] { null, null, new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7288) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                columns: new[] { "Account", "Password", "RegistrationDate" },
                values: new object[] { null, null, new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                columns: new[] { "Account", "Password", "RegistrationDate" },
                values: new object[] { null, null, new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                columns: new[] { "Account", "Password", "RegistrationDate" },
                values: new object[] { null, null, new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7296) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                columns: new[] { "Account", "Password", "RegistrationDate" },
                values: new object[] { null, null, new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7298) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                columns: new[] { "Account", "Password", "RegistrationDate" },
                values: new object[] { null, null, new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7299) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                columns: new[] { "Account", "Password", "RegistrationDate" },
                values: new object[] { null, null, new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7301) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                columns: new[] { "Account", "Password", "RegistrationDate" },
                values: new object[] { null, null, new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                columns: new[] { "Account", "Password", "RegistrationDate" },
                values: new object[] { null, null, new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7309) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                columns: new[] { "Account", "Password", "RegistrationDate" },
                values: new object[] { null, null, new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7311) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7102), new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7092) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7104), new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7106), new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7105) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7107), new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7107) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7109), new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7139));
        }
    }
}
