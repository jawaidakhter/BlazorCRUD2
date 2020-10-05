using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorCRUD.Data.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 10, 5, 15, 18, 30, 94, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 10, 5, 15, 18, 30, 94, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2020, 10, 5, 15, 18, 30, 94, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 10, 5, 15, 18, 30, 90, DateTimeKind.Local).AddTicks(187));

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 10, 5, 15, 18, 30, 95, DateTimeKind.Local).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 10, 5, 15, 18, 30, 96, DateTimeKind.Local).AddTicks(593));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 10, 5, 14, 37, 35, 671, DateTimeKind.Local).AddTicks(3003));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 10, 5, 14, 37, 35, 671, DateTimeKind.Local).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2020, 10, 5, 14, 37, 35, 671, DateTimeKind.Local).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 10, 5, 14, 37, 35, 667, DateTimeKind.Local).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 10, 5, 14, 37, 35, 672, DateTimeKind.Local).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 10, 5, 14, 37, 35, 672, DateTimeKind.Local).AddTicks(8934));
        }
    }
}
