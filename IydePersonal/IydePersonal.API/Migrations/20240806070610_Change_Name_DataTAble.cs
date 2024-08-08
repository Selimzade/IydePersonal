using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IydePersonal.API.Migrations
{
    /// <inheritdoc />
    public partial class Change_Name_DataTAble : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePunkt_Employees_EmployeeId",
                table: "EmployeePunkt");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePunkt_Punkts_PunktId",
                table: "EmployeePunkt");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Salary_SalaryId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_User_UserId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Punkts",
                table: "Punkts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Punkts",
                newName: "Punkt");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_UserId",
                table: "Employee",
                newName: "IX_Employee_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_SalaryId",
                table: "Employee",
                newName: "IX_Employee_SalaryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Punkt",
                table: "Punkt",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Salary_SalaryId",
                table: "Employee",
                column: "SalaryId",
                principalTable: "Salary",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_User_UserId",
                table: "Employee",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePunkt_Employee_EmployeeId",
                table: "EmployeePunkt",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePunkt_Punkt_PunktId",
                table: "EmployeePunkt",
                column: "PunktId",
                principalTable: "Punkt",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Salary_SalaryId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_User_UserId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePunkt_Employee_EmployeeId",
                table: "EmployeePunkt");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePunkt_Punkt_PunktId",
                table: "EmployeePunkt");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Punkt",
                table: "Punkt");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.RenameTable(
                name: "Punkt",
                newName: "Punkts");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_UserId",
                table: "Employees",
                newName: "IX_Employees_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_SalaryId",
                table: "Employees",
                newName: "IX_Employees_SalaryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Punkts",
                table: "Punkts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePunkt_Employees_EmployeeId",
                table: "EmployeePunkt",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePunkt_Punkts_PunktId",
                table: "EmployeePunkt",
                column: "PunktId",
                principalTable: "Punkts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Salary_SalaryId",
                table: "Employees",
                column: "SalaryId",
                principalTable: "Salary",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_User_UserId",
                table: "Employees",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
