using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IydePersonal.API.Migrations
{
    /// <inheritdoc />
    public partial class update_entity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Salary_SalaryId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Salary",
                table: "Salary");

            migrationBuilder.RenameTable(
                name: "Salary",
                newName: "Salaries");

            migrationBuilder.RenameColumn(
                name: "StorePercent",
                table: "Salaries",
                newName: "TotalCheck");

            migrationBuilder.RenameColumn(
                name: "Generalcheck",
                table: "Salaries",
                newName: "Sales");

            migrationBuilder.AddColumn<int>(
                name: "AdditionalBonus",
                table: "Salaries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Salaries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Payment",
                table: "Salaries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Salaries",
                table: "Salaries",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Salaries_SalaryId",
                table: "Employees",
                column: "SalaryId",
                principalTable: "Salaries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Salaries_SalaryId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Salaries",
                table: "Salaries");

            migrationBuilder.DropColumn(
                name: "AdditionalBonus",
                table: "Salaries");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Salaries");

            migrationBuilder.DropColumn(
                name: "Payment",
                table: "Salaries");

            migrationBuilder.RenameTable(
                name: "Salaries",
                newName: "Salary");

            migrationBuilder.RenameColumn(
                name: "TotalCheck",
                table: "Salary",
                newName: "StorePercent");

            migrationBuilder.RenameColumn(
                name: "Sales",
                table: "Salary",
                newName: "Generalcheck");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Salary",
                table: "Salary",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Salary_SalaryId",
                table: "Employees",
                column: "SalaryId",
                principalTable: "Salary",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
