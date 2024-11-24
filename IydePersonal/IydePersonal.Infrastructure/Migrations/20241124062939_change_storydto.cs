using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IydePersonal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class change_storydto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dd695e6c-7451-45f3-b3f1-90a45b67997c", "AQAAAAIAAYagAAAAEAv34fIbzLP6cyaSxBk+dGdnC6iZ4mKIucp+gdaheBO760FeFMz4JXbxY+bXf4Y2EQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c61883d9-4028-4e28-8770-0f9d55c0f4c4", "AQAAAAIAAYagAAAAEOPSW3D4vWDbhq85JfQqf7tyGmPBHB9MpWR2eZHpoIHvfFngEtT5V6Pn69J0KyJreQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9a4ed6bd-931f-42ef-9d8d-a3f192e26033", "AQAAAAIAAYagAAAAEKY6yxfnFVLoxXs6zhfxBsO1P0bnQVf3DfavRZv0EO65k1ovJcvKLxRjkXiMqcVnOQ==" });

            migrationBuilder.UpdateData(
                table: "EmployeePunkts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 24, 9, 29, 39, 62, DateTimeKind.Local).AddTicks(3736));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "53da27da-dcdc-4eaa-83a0-4d883e327a00", "AQAAAAIAAYagAAAAEAn/3Jd423K/S7U1AEra8CiTRMaEtAZOcbGUI4HYZMO34ti3bGFMpvLsf/Fe1qCO1g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ceecc650-bb21-437d-9c50-2433861707b7", "AQAAAAIAAYagAAAAEJqSubftrdbvvS/0eG/FCIxNcAEof1AfdUbnDj7HeplLz0xih+im7RuElRvSvsFSZA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d849de46-c930-44d9-be13-eb5d97863536", "AQAAAAIAAYagAAAAEOvCjHMnRJrMlYCzfSCaI4EnTm4iikYcAGgI0wS44Q/X1+aHrxX9L3TBaV3IR+36qw==" });

            migrationBuilder.UpdateData(
                table: "EmployeePunkts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 19, 13, 7, 10, 782, DateTimeKind.Local).AddTicks(3439));
        }
    }
}
