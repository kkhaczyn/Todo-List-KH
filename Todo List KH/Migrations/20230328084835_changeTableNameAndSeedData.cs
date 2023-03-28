using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Todo_List_KH.Migrations
{
    public partial class changeTableNameAndSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.CreateTable(
                name: "ToDoItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ExecutionTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDoItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ToDoItems",
                columns: new[] { "Id", "ExecutionTime", "IsCompleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), false, "Podlać kwiaty" },
                    { 28, new DateTime(2023, 4, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), false, "Wyprowadzić psa na spacer" },
                    { 27, new DateTime(2023, 4, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), false, "Zjeść obiad" },
                    { 26, new DateTime(2023, 4, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), false, "Podlać kwiaty" },
                    { 25, new DateTime(2023, 4, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), false, "Zjeść kolację" },
                    { 24, new DateTime(2023, 4, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), false, "Zrobić zakupy" },
                    { 23, new DateTime(2023, 4, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), false, "Wyprowadzić psa na spacer" },
                    { 22, new DateTime(2023, 4, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), false, "Zjeść obiad" },
                    { 21, new DateTime(2023, 4, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), false, "Podlać kwiaty" },
                    { 20, new DateTime(2023, 3, 31, 20, 0, 0, 0, DateTimeKind.Unspecified), false, "Zjeść kolację" },
                    { 19, new DateTime(2023, 3, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), false, "Zrobić zakupy" },
                    { 18, new DateTime(2023, 3, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), false, "Wyprowadzić psa na spacer" },
                    { 17, new DateTime(2023, 3, 31, 14, 0, 0, 0, DateTimeKind.Unspecified), false, "Zjeść obiad" },
                    { 16, new DateTime(2023, 3, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), false, "Podlać kwiaty" },
                    { 15, new DateTime(2023, 3, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), false, "Zjeść kolację" },
                    { 14, new DateTime(2023, 3, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), false, "Zrobić zakupy" },
                    { 13, new DateTime(2023, 3, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), false, "Wyprowadzić psa na spacer" },
                    { 12, new DateTime(2023, 3, 30, 14, 0, 0, 0, DateTimeKind.Unspecified), false, "Zjeść obiad" },
                    { 11, new DateTime(2023, 3, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), false, "Podlać kwiaty" },
                    { 10, new DateTime(2023, 3, 29, 20, 0, 0, 0, DateTimeKind.Unspecified), false, "Zjeść kolację" },
                    { 9, new DateTime(2023, 3, 29, 18, 0, 0, 0, DateTimeKind.Unspecified), false, "Zrobić zakupy" },
                    { 8, new DateTime(2023, 3, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), false, "Wyprowadzić psa na spacer" },
                    { 7, new DateTime(2023, 3, 29, 14, 0, 0, 0, DateTimeKind.Unspecified), false, "Zjeść obiad" },
                    { 6, new DateTime(2023, 3, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), false, "Podlać kwiaty" },
                    { 5, new DateTime(2023, 3, 28, 20, 0, 0, 0, DateTimeKind.Unspecified), false, "Zjeść kolację" },
                    { 4, new DateTime(2023, 3, 28, 18, 0, 0, 0, DateTimeKind.Unspecified), false, "Zrobić zakupy" },
                    { 3, new DateTime(2023, 3, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), false, "Wyprowadzić psa na spacer" },
                    { 2, new DateTime(2023, 3, 28, 14, 0, 0, 0, DateTimeKind.Unspecified), false, "Zjeść obiad" },
                    { 29, new DateTime(2023, 4, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), false, "Zrobić zakupy" },
                    { 30, new DateTime(2023, 4, 2, 20, 0, 0, 0, DateTimeKind.Unspecified), false, "Zjeść kolację" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToDoItems");

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExecutionTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                });
        }
    }
}
