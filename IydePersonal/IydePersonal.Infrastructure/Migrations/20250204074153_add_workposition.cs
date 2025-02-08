using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IydePersonal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class add_workposition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6574482c-9dbc-42ee-9d28-e35fccb0bbae", "AQAAAAIAAYagAAAAEFZAXVer1gcatQtzPqsN3jmxMRfUP3VfMNYqEzqMZW9SSydq3b3OJnkoXnS8mNrW/A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d77d10f5-7fa0-4f3b-a74d-ea7ca17d89f4", "AQAAAAIAAYagAAAAEKy8scTQLhcZ5t80bQXHL/05jCht8yDhQJUkOgAJ0N5puI826bFD6i3RXOJs5Y2ynw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f0e36902-4fc2-431d-b9d2-1475541a199c", "AQAAAAIAAYagAAAAEDuEpVNMfPZOAtZFVSZ0VMvujdV07l1V4ivYN8lDz++oPBnvXiSo1d8tIy3Q8hGWLw==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
