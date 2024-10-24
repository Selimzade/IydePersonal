using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IydePersonal.API.Migrations
{
    /// <inheritdoc />
    public partial class addseeddata2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Punkts",
                columns: new[] { "Id", "Name", "Point" },
                values: new object[] { 1, "Nizami intizam pozmaq", 20 });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Azadliq" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "FinishWork", "Firstname", "FixSalary", "Gender", "IsActive", "Lastname", "PhoneNumber", "StartWork", "StoreId", "UserId", "WorkPosition" },
                values: new object[] { 1, new DateTime(1987, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 13, 50, 1, 488, DateTimeKind.Local).AddTicks(741), "Ehmed", 1000, (byte)1, true, "Mustafa", "502330644", new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, (byte)2 });

            migrationBuilder.InsertData(
                table: "EmployeePunkts",
                columns: new[] { "Id", "CreateDate", "EmployeeId", "PunktId" },
                values: new object[] { 1, new DateTime(2024, 10, 23, 13, 50, 1, 488, DateTimeKind.Local).AddTicks(6058), 1, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeePunkts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Punkts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
