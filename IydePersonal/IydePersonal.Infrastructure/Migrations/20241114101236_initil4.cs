using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IydePersonal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initil4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "83a19c77-00dd-40f5-bcf4-a512132ad5fe", "AQAAAAIAAYagAAAAEGSFyQ/WvyJ26SqKoVGlIynmJdmEyezfGBpJ86wjWDl8ORRxGusJh8k6TauarEVUXw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d825ecd0-3ca6-4cfb-a5b0-d32ae44d1342", "AQAAAAIAAYagAAAAEOP6ukT19zr/nry5vFBWhgJkRGED43R4l5CtirNwn8GTDbAwcdovZh+TfjgXdr2JlQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9f96a3a1-71d1-4da1-a4fd-bd17bb55b549", "AQAAAAIAAYagAAAAEKvxMGU1AlnkcAn9Bv3JOx1YvW6uhq9lDdvBIOv/TL+1enYS1KiGQ+PoHW8x0R0SdA==" });

            migrationBuilder.UpdateData(
                table: "EmployeePunkts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 14, 13, 12, 35, 178, DateTimeKind.Local).AddTicks(7719));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Adress", "DateOfBirth", "FinishWork", "Firstname", "FixSalary", "Gender", "IsActive", "Lastname", "PhoneNumber", "StartWork", "StoreId", "UserId", "WorkPosition" },
                values: new object[] { 1, "Baki", new DateTime(1987, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 13, 10, 26, 44, 451, DateTimeKind.Local).AddTicks(5354), "Ehmed", 1000, (byte)1, true, "Mustafa", "502330644", new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, (byte)2 });
        }
    }
}
