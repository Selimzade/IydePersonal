using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IydePersonal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class change_employeeentity_delete_store : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Stores_StoreId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_StoreId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "StoreId",
                table: "Employees");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "614dd64c-44d9-47f2-ab3a-4bcf4094b072", "AQAAAAIAAYagAAAAEOeNvic6+1ccOCJDeUNzuaLy67B8nceNJ9Hb8UIHO5S/RXYemtOOOh8vbFFIi/EHCw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dc719155-7efc-4a97-b947-e820f216f4bc", "AQAAAAIAAYagAAAAEKgPjKKODym/uLIE6kFWA+9E5/ARjOU/GAPKewVKYbx+nUYUDZZg8EX0CIEwkzN/Ng==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3d21c39a-cb40-4454-b7e3-d015c7787e91", "AQAAAAIAAYagAAAAEJ/rq1RNq4Nlxib8kUGpa2jRbflSB5FyZ/QynKf6Afdx8ZtO1zTXpen6JiooNnauxA==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StoreId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Employees_StoreId",
                table: "Employees",
                column: "StoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Stores_StoreId",
                table: "Employees",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
