using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyTodo.Migrations
{
    /// <inheritdoc />
    public partial class Seeddefaulttododata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Title", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Test", new DateTime(2024, 1, 10, 22, 22, 14, 52, DateTimeKind.Local).AddTicks(8711), "Trying finish database", "Finish Program", "Test", new DateTime(2024, 1, 10, 22, 22, 14, 52, DateTimeKind.Local).AddTicks(8740) },
                    { 2, "Test", new DateTime(2024, 1, 10, 22, 22, 14, 52, DateTimeKind.Local).AddTicks(8743), "getting a brand new Toyota Supra", "Get new card", "Test", new DateTime(2024, 1, 10, 22, 22, 14, 52, DateTimeKind.Local).AddTicks(8744) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
