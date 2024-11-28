using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IydePersonal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class change_emp_users : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Users_UserId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c3fa1a3c-b189-4871-a572-8b7b43fec1dd", "AQAAAAIAAYagAAAAEJQn3EoFFkGUYavpBjc6jON0fGogwSl0stkeVis7oxHSWWRzAR4CV+TxgBEOFwleNA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2fa21b5c-f527-48d8-ac07-83cba4c12f18", "AQAAAAIAAYagAAAAEPpnLp5A5MtMSDbodmqEkdDUFKSGNrk0IwG5eyTve6zUcrkl3RrIpyYBSsoBiUpFtQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0a2ad777-daf4-4979-a3e6-8dfcd13484d6", "AQAAAAIAAYagAAAAENVzCZ2SW9kx9EOB/B+YUBjLC4zHpDKCNy5MoJu+7un5z/yaOcR08o3xHHw9GYEsBA==" });

            migrationBuilder.UpdateData(
                table: "EmployeePunkts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 28, 11, 3, 12, 532, DateTimeKind.Local).AddTicks(38));

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_AspNetUsers_UserId",
                table: "Employees",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_AspNetUsers_UserId",
                table: "Employees");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[] { 1, "123456", "Azadliq" });

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Users_UserId",
                table: "Employees",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
