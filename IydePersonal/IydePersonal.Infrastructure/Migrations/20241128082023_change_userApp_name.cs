using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IydePersonal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class change_userApp_name : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FisrtName",
                table: "AspNetUsers",
                newName: "FirstName");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f50f1f43-f10c-4db2-9920-e9222f33cae1", "AQAAAAIAAYagAAAAEN7KqFVgBdXl03j5uwcwDhnMmCtAL23rcEYbc7eEpR1idTg6lM3ejPOHnyC+gphJqg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bde7097b-5b6e-42bc-bc27-b5a4a5e884a2", "AQAAAAIAAYagAAAAEDGI5ow/tnMWl0kCluNk8cGaN457UWf8iVfsKC5JHjDTYFZdO5CrWYFzLXycF7y5Zg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a6dce4e3-bcaf-42c0-a3df-7f5c86d930cb", "AQAAAAIAAYagAAAAEO3wvVbvPHzdpyU41oFe1TrNPCLeT8JD/61E80vaqCMHXdvYi65oOUKBBo3RfR42Gg==" });

            migrationBuilder.UpdateData(
                table: "EmployeePunkts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 28, 11, 20, 22, 883, DateTimeKind.Local).AddTicks(4678));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "AspNetUsers",
                newName: "FisrtName");

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
        }
    }
}
