using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IydePersonal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Change_employee_delete_lastname_change_fisrtName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lastname",
                table: "Employees");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Lastname",
                table: "Employees",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d112979e-2c99-4dd2-89ec-bcec42392619", "AQAAAAIAAYagAAAAEMCzREqtlNEfgq2Ul7AzbTTO99n+KknPAgJVw4JE/X8rZricfOmzzmzOjGRn7Zry3A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e23df910-2d3b-47d2-b1d6-cc64aa924cad", "AQAAAAIAAYagAAAAEJrm1xlWvo7GpGZ5bF9PNmhNeLaoDx5Ls+/LbD7GMKC9Ib/YLI2+m2bHwkNufTr/Fg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c063806d-80e3-46af-b3a2-3615f3cba752", "AQAAAAIAAYagAAAAEAUtwZ1jaTugvmyzovO04/1g/YFFCOLHAtht9ugD+Uh9yvANDnNrnAsqkfEeEJrJOw==" });
        }
    }
}
