using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IydePersonal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Change_employee_delete_lastname_change_fisrtName_ : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Firstname",
                table: "Employees",
                newName: "FullName");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "193c4d35-43d7-4dbb-81c6-a9fdfd03f3e6", "AQAAAAIAAYagAAAAEKhq6psdaNbZ1aYV9sdLmD7JrIKI3loZsaRlqF8alb7f0B4O+RzrINZii6XCYg1quw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ffb238bf-73f6-457e-a938-b0db543928ad", "AQAAAAIAAYagAAAAEBWPuc2HsPRHh9yq1KiaKMiCy+pdulQTkzxECMn5S3aJrjT+fbwaZWe8tg+x9U4DYg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "482420c1-29ae-46b6-85bc-428293823926", "AQAAAAIAAYagAAAAEFosJQ9TSoTtmoNBUFDlZuR06q2AOdOiCCa7ID3y1vVH6V4VhXDGx4OE9Wq+RB8UbQ==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Employees",
                newName: "Firstname");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "92c9f27a-3a93-4c44-9d7d-a0feedf4fba9", "AQAAAAIAAYagAAAAEE89ujbLdp79MktiNOWCNw5JWIEQtRdf7ZGi03wc87oguiC5TWcnAceH9ijoPXNYMA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "45488243-c7d4-4e32-a788-063f782754f0", "AQAAAAIAAYagAAAAEGA/yn1DioLIjU9ePCLQy/TL7sFm7ZAlkO6pgI+p4coi9XlCcZCPGuS/FyiKeyb14Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8b657fe6-7915-446e-9bbe-fd0e743d0585", "AQAAAAIAAYagAAAAEJIhr8SK7kk9pW0xmv3iHhSb4rktmIklQllnpLr8M8go6Lj6t7rOoHUN6lnvWEyc0w==" });
        }
    }
}
