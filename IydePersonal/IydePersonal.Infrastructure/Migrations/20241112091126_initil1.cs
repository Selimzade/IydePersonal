using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IydePersonal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initil1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3b2cf055-eb7b-49d1-8f26-232ee2b69395", "AQAAAAIAAYagAAAAEOW1kn8yWijv8bHX6+XElkpDHkFVV48yc5Gh6xaydk/GpBE6cvbYImmwmucVUgjyqw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "44fefa55-84ee-48f3-8e9f-a35cb3b33791", "AQAAAAIAAYagAAAAED2GNRl3QifSuoi44vu9vxEZkeTGNUVnSRdTliz3kYOP6EXz2GS965pS1AKDZMvdyw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bd418eec-14fa-481d-bfdd-55f211c460bb", "AQAAAAIAAYagAAAAEKBlu8LkPJ/ILVNHa8OwE2uc5ul1+IAfEKhVhIUqTXWPF2UbcHoOI4D+I0sEkGjOTw==" });

            migrationBuilder.UpdateData(
                table: "EmployeePunkts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 12, 11, 25, 606, DateTimeKind.Local).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Adress", "FinishWork" },
                values: new object[] { "Baki", new DateTime(2024, 11, 12, 12, 11, 25, 605, DateTimeKind.Local).AddTicks(6372) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Employees");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "147360aa-71ae-4683-81ea-481003f51177", "AQAAAAIAAYagAAAAENeKqmYXUfm6wZ24krO8u3oxLB29HAaOuGqz1ZV8g2m44qLecwfTYM6C3ZRpD0oqig==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "81c6df06-61ae-48bb-90f2-89d34535440a", "AQAAAAIAAYagAAAAEJ3xRIGSA5JKNJ9hPPiQ24sPCoGQAnkJRDUXT8nA8rEXp1Q96Buslh/AH5e4jVjVKg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f7c50372-4735-4a76-94eb-15abe24340d1", "AQAAAAIAAYagAAAAEDWQ4J14I24R28m2XxN3+tyc5FdBGNpt627exlLN1gTdslRhmeZLzZv/Q/u/9UIOGg==" });

            migrationBuilder.UpdateData(
                table: "EmployeePunkts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 12, 8, 43, 2, 777, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "FinishWork",
                value: new DateTime(2024, 11, 12, 8, 43, 2, 776, DateTimeKind.Local).AddTicks(1797));
        }
    }
}
