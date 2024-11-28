using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IydePersonal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class change_emp_modified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Employees",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "83964c5a-9338-45d9-b4ae-c5678552e08f", "AQAAAAIAAYagAAAAEPGwxFu/MYDS/HPfA3I8PswusntdsQSb+fnudd4cWWtpUmQsgjTY8hEV5ONi/k+2Lw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fe3c9fb7-50d3-46f2-9600-e196a5f39449", "AQAAAAIAAYagAAAAEIMWQlLiEgmAAljFTSHLLBvwOdzHhCSwYDrTThjy7aYxrzGAjWqbP5OJFwtaVS2FQw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a5ea90f7-5c9e-4036-8da9-d7838bd7a6d7", "AQAAAAIAAYagAAAAEFotD8iVv/1PR8cosgdgftvaVq/FvNeVweCiMZXlVDYawoxVU7n8JqUq/1S8r5qTDQ==" });

            migrationBuilder.UpdateData(
                table: "EmployeePunkts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 28, 7, 48, 25, 127, DateTimeKind.Local).AddTicks(4637));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
    }
}
