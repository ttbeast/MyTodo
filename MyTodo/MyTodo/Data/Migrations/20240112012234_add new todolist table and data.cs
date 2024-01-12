using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyTodo.Migrations
{
    /// <inheritdoc />
    public partial class addnewtodolisttableanddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ToDoLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDoLists", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ToDoLists",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Title", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Test", new DateTime(2024, 1, 11, 19, 22, 33, 870, DateTimeKind.Local).AddTicks(9475), "Trying finish database", "Finish Program", "Test", new DateTime(2024, 1, 11, 19, 22, 33, 870, DateTimeKind.Local).AddTicks(9476) },
                    { 2, "Test", new DateTime(2024, 1, 11, 19, 22, 33, 870, DateTimeKind.Local).AddTicks(9477), "getting a brand new Toyota Supra", "Get new card", "Test", new DateTime(2024, 1, 11, 19, 22, 33, 870, DateTimeKind.Local).AddTicks(9478) }
                });

            migrationBuilder.UpdateData(
                table: "Todoes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 19, 22, 33, 870, DateTimeKind.Local).AddTicks(9327), new DateTime(2024, 1, 11, 19, 22, 33, 870, DateTimeKind.Local).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "Todoes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 19, 22, 33, 870, DateTimeKind.Local).AddTicks(9363), new DateTime(2024, 1, 11, 19, 22, 33, 870, DateTimeKind.Local).AddTicks(9364) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToDoLists");

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
    }
}
