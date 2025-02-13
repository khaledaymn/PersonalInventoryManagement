using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PersonalInventoryManagement.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SeedingNewData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "ExpireDate", "ImageURL", "Name", "Price", "Quantity", "UserId" },
                values: new object[,]
                {
                    { 1000, 100, new DateTime(2028, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Images/Products/1.jpg", "Laptop", 1500.99m, 3, 3 },
                    { 1010, 100, new DateTime(2027, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Images/Products/2.jpg", "Smartphone", 799.99m, 1, 3 },
                    { 1020, 101, new DateTime(2025, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Images/Products/3.jpg", "T-Shirt", 19.99m, 2, 3 },
                    { 1030, 101, new DateTime(2026, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Images/Products/4.jpg", "Jeans", 39.99m, 3, 3 },
                    { 1040, 102, new DateTime(2029, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Images/Products/5.jpg", "Washing Machine", 499.99m, 2, 3 },
                    { 1050, 102, new DateTime(2030, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Images/Products/6.jpg", "Refrigerator", 899.99m, 2, 3 },
                    { 1060, 103, new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Images/Products/7.jpg", "Fiction Novel", 12.99m, 1, 3 },
                    { 1070, 104, new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Images/Products/8.jpg", "Children's Toy Car", 25.99m, 3, 3 },
                    { 1080, 105, new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Images/Products/9.jpg", "Basketball", 29.99m, 2, 3 },
                    { 1090, 106, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Images/Products/10.jpg", "Dumbbells Set", 99.99m, 1, 3 },
                    { 1100, 101, new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Images/Products/11.jpg", "Running Shoes", 49.99m, 2, 3 },
                    { 1200, 103, new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Images/Products/12.jpg", "Winter Jacket", 89.99m, 3, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1050);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1060);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1070);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1080);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1090);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1100);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1200);
        }
    }
}
