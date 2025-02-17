using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IydePersonal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Add_code_invertar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Inventories",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Inventories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Inventories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Codebar",
                table: "Inventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "948bd8ad-8296-490b-a50e-5f97cbf31ad6", "AQAAAAIAAYagAAAAENV+qlBb3pZuM6ujwh66WNbgQUwN0hUXkZ5mIkDNjgzvFvoNlcaKjJJnfltuuRFRRg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "823ca23f-24c1-427d-939d-bd6452205445", "AQAAAAIAAYagAAAAEC4oHW2HLYAWMOPrDQbZ+WftpwX7WEH4CyQX+W+EV1YDnUSkeWEkKxqcK2feEjMUFg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9a6ffb71-19e1-4d82-8c0e-e50ec2fff350", "AQAAAAIAAYagAAAAEKwggGzgCXHgOaBE1PGo+AlvWMJu0yCfWSLsJvSThhAJi94PeuIztyS1XgNWNDZKfw==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Codebar",
                table: "Inventories");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Inventories",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Inventories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Inventories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c50970d3-b661-4248-978f-d5d210154aa4", "AQAAAAIAAYagAAAAEMYuiWgfQt++giBjpMUS9kI5XKFTtSHdJg7sxfnxE6XcOLp2vHcmcl+vonJbbii8+g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fc5eb5fc-4429-4252-8330-93626682ff5c", "AQAAAAIAAYagAAAAEPUFc9ePrLd8zytVqP+sez82AsUITlv4a1HGyVwaNOCKPQBG+XkIaeSLcD2nrWfbaQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "60db5f86-7bf3-4667-973f-29bfabbf561d", "AQAAAAIAAYagAAAAECLdDUZ11RwwgktafFn4K2XxENAWSa3QskU19XlgHX68nCwS5PcvlrdcjyxwgRdvAQ==" });
        }
    }
}
