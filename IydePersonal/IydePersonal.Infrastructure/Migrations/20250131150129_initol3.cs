using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IydePersonal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initol3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeleteDates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeleteDates", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e9bc56b1-4289-46d8-9015-6ecabef01794", "AQAAAAIAAYagAAAAEGkwQkBMh/KgJ6GKbbr+4p6o5eVdzxUopXL6jFp37VsYzFsDgG59mb9TkFKHYmp7bg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a73394aa-85a8-4ac1-b34e-e5dad944ac8b", "AQAAAAIAAYagAAAAEKbNYdpHaeBJp5JjqPuo6FJm/5AtluF8F7N8eRr4BYak/tOjYR5+RaxrRycLIBm1JA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9be847df-5b61-4052-8941-8fa550b59dc0", "AQAAAAIAAYagAAAAECD8pY1vA277tyPuLJkCxaiNe158/ObbyvG1yuMbcO5Z/uRNlnqC82i0UBz+3weLFQ==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeleteDates");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3b1c830e-ab69-47c1-b2ab-59df44682109", "AQAAAAIAAYagAAAAEExEe7T/0a4skJ9mjq/LTjIgGYU59Ek8n924EbyDSgh40KamN9hAuprGPtkSrFq/LA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d08fe839-6c84-4f26-bc91-e53add16ef40", "AQAAAAIAAYagAAAAEHyern8KcjuCaJN6hCVfBBqtp27BiXiOOQ574KifOCNiqHgzyL2ZPM056G0LEH9kaw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "169d4e82-ef6f-4a6a-b7bb-4a58757c8467", "AQAAAAIAAYagAAAAEIUtbY0El/qteBAB6fFhboMcwBEN5yvKNmmjuUvlp/46LOtoNWamZmw3R7QkBcbl+A==" });
        }
    }
}
