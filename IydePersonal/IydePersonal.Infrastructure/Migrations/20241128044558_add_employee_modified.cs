using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IydePersonal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class add_employee_modified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "afa33195-b9a4-4589-8a22-4dbf9fbed7e9", "AQAAAAIAAYagAAAAEKk5zmmhsPKGVAXwOlKYIKCw2JTCuFgn+L+jrzSEELyPluoJd7A5chktRaCgao6doQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6c723252-5965-4973-9310-8bba1d80b5c3", "AQAAAAIAAYagAAAAEEoc0wsgCOfNSr6pq49VPJGWvMr3AZZjbriP2tiCTwdm1YeMdk8O9x4M8wa9q9aEdg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a024bf76-1844-480a-9e49-36e8fb53290d", "AQAAAAIAAYagAAAAECauZzQXsGfv5+xFDzQIhlx1Fzv/rpHitvtiZU4d/DvIMcbiSmjG0dyKPC1XHyywYQ==" });

            migrationBuilder.UpdateData(
                table: "EmployeePunkts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 28, 7, 45, 57, 823, DateTimeKind.Local).AddTicks(4623));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Employees");

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
    }
}
