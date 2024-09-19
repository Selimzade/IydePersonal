using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IydePersonal.API.Migrations
{
    /// <inheritdoc />
    public partial class add_user_column_and_add_change_emp_column : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "User",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "shop",
                table: "Employee",
                newName: "Store");

            migrationBuilder.AddColumn<string>(
                name: "PassWord",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PassWord",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "User",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Store",
                table: "Employee",
                newName: "shop");
        }
    }
}
