using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PersonalInventoryManagement.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "ExpireDate", "ImageURL", "Name", "Price", "Quantity", "UserId" },
                values: new object[,]
                {
                    { 100, 100, new DateTime(2028, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Images/Products/1.jpg", "Laptop", 1500.99m, 3, 3 },
                    { 101, 100, new DateTime(2027, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Images/Products/2.jpg", "Smartphone", 799.99m, 1, 3 },
                    { 102, 101, new DateTime(2026, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Images/Products/3.jpg", "T-Shirt", 19.99m, 2, 3 },
                    { 103, 101, new DateTime(2026, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Images/Products/4.jpg", "Jeans", 39.99m, 3, 3 },
                    { 104, 102, new DateTime(2030, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Images/Products/5.jpg", "Washing Machine", 499.99m, 2, 3 },
                    { 105, 102, new DateTime(2032, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Images/Products/6.jpg", "Refrigerator", 899.99m, 2, 3 },
                    { 106, 103, new DateTime(2035, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Images/Products/7.jpg", "Fiction Novel", 12.99m, 1, 3 },
                    { 107, 104, new DateTime(2028, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Images/Products/8.jpg", "Children's Toy Car", 25.99m, 3, 3 },
                    { 108, 105, new DateTime(2029, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Images/Products/9.jpg", "Basketball", 29.99m, 2, 3 },
                    { 109, 106, new DateTime(2033, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Images/Products/10.jpg", "Dumbbells Set", 99.99m, 1, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109);

        }
    }
}
