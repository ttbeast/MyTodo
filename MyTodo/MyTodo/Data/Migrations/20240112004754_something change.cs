using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyTodo.Migrations
{
    /// <inheritdoc />
    public partial class somethingchange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Todos",
                table: "Todos");

            migrationBuilder.RenameTable(
                name: "Todos",
                newName: "Todoes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Todoes",
                table: "Todoes",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Todoes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 18, 47, 53, 376, DateTimeKind.Local).AddTicks(4518), new DateTime(2024, 1, 11, 18, 47, 53, 376, DateTimeKind.Local).AddTicks(4550) });

            migrationBuilder.UpdateData(
                table: "Todoes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 18, 47, 53, 376, DateTimeKind.Local).AddTicks(4552), new DateTime(2024, 1, 11, 18, 47, 53, 376, DateTimeKind.Local).AddTicks(4553) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Todoes",
                table: "Todoes");

            migrationBuilder.RenameTable(
                name: "Todoes",
                newName: "Todos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Todos",
                table: "Todos",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 22, 14, 52, DateTimeKind.Local).AddTicks(8711), new DateTime(2024, 1, 10, 22, 22, 14, 52, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 22, 14, 52, DateTimeKind.Local).AddTicks(8743), new DateTime(2024, 1, 10, 22, 22, 14, 52, DateTimeKind.Local).AddTicks(8744) });
        }
    }
}
