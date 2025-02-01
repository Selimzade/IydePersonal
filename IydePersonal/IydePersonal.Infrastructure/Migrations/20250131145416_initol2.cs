using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IydePersonal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initol2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3b1c830e-ab69-47c1-b2ab-59df44682109", "AQAAAAIAAYagAAAAEExEe7T/0a4skJ9mjq/LTjIgGYU59Ek8n924EbyDSgh40KamN9hAuprGPtkSrFq/LA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d08fe839-6c84-4f26-bc91-e53add16ef40", "AQAAAAIAAYagAAAAEHyern8KcjuCaJN6hCVfBBqtp27BiXiOOQ574KifOCNiqHgzyL2ZPM056G0LEH9kaw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "169d4e82-ef6f-4a6a-b7bb-4a58757c8467", "AQAAAAIAAYagAAAAEIUtbY0El/qteBAB6fFhboMcwBEN5yvKNmmjuUvlp/46LOtoNWamZmw3R7QkBcbl+A==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "49338f71-dab6-4511-8745-cfe8688d5414", "AQAAAAIAAYagAAAAEJ/XKSdrk1tehXapH+CyZPgiMG/wo5C0KxhjUOjvNa/+ebcaBUagk9iGFgeYEm2feQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ea0afe22-4e20-486f-8151-92d9a2b4053a", "AQAAAAIAAYagAAAAEAv6gm+I/khQLkRmHqI/+Pn8YQGhrTiRwFif0bZtNJk+m3Fo8DMRbws+Ttchd+b1IA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dd757bb9-6c8b-4db6-8c81-d6f884e51fc3", "AQAAAAIAAYagAAAAELXgD8q6UM+k2GIzjipGtV+vl7Vf+AXoZBaMaQ4miHasNThRBE7nvNGgaeju+8/tKA==" });
        }
    }
}
