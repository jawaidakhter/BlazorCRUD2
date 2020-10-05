using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorCRUD.Data.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 10, 5, 14, 37, 35, 671, DateTimeKind.Local).AddTicks(3003));

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 2, "jawaid", new DateTime(2020, 10, 5, 14, 37, 35, 671, DateTimeKind.Local).AddTicks(4308), null, null, "AC/Fridge" },
                    { 3, "jawaid", new DateTime(2020, 10, 5, 14, 37, 35, 671, DateTimeKind.Local).AddTicks(4334), null, null, "Auto Parts" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Company", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate", "ProductCategoryId", "SKU", "Title" },
                values: new object[] { 1, "Nokia 123", "Nokia", "jawaid", new DateTime(2020, 10, 5, 14, 37, 35, 667, DateTimeKind.Local).AddTicks(2263), null, null, 1, "EP-1-1", "Nokia 123 Prime" });

            migrationBuilder.InsertData(
                table: "Vendors",
                columns: new[] { "Id", "CompnayName", "ContactPerson", "CreatedBy", "CreatedDate", "Email", "ModifiedBy", "ModifiedDate", "Phone" },
                values: new object[,]
                {
                    { 1, "Alex", "Yasir", "jawaid", new DateTime(2020, 10, 5, 14, 37, 35, 672, DateTimeKind.Local).AddTicks(7244), "", null, null, "1234" },
                    { 2, "Galaxy", "Saleem", "jawaid", new DateTime(2020, 10, 5, 14, 37, 35, 672, DateTimeKind.Local).AddTicks(8934), "", null, null, "1234" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 10, 5, 14, 35, 40, 480, DateTimeKind.Local).AddTicks(4672));
        }
    }
}
