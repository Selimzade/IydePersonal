using System;
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
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cd2d4583-2a1e-4c37-ab68-1963694acef9", "AQAAAAIAAYagAAAAEJINtoj61bLLV9jwyrtxsF38/FvrtLCoo9IIT7sA/SQm8DUysfnA2u63IeSumb+fqw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c55b6fb5-a5dd-43e6-a9e0-3bc10f1f6b79", "AQAAAAIAAYagAAAAEHhdALVJ0c89RH+uRlxmYQz2rjCdVU3SrYerehtgHt+TtnVMDI/DPSwLPIcnhOEc8Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0920dd80-fd74-4452-a7cd-9dbd2b734d39", "AQAAAAIAAYagAAAAEHRsvpbfo8O9ie3HIeSVOy2sfaX92mlkMuJkWx0q5xBEVToU9xGhDWjcatWQ4TC0fQ==" });

            migrationBuilder.UpdateData(
                table: "EmployeePunkts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 13, 10, 26, 44, 452, DateTimeKind.Local).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "FinishWork",
                value: new DateTime(2024, 11, 13, 10, 26, 44, 451, DateTimeKind.Local).AddTicks(5354));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                column: "FinishWork",
                value: new DateTime(2024, 11, 12, 12, 11, 25, 605, DateTimeKind.Local).AddTicks(6372));
        }
    }
}
