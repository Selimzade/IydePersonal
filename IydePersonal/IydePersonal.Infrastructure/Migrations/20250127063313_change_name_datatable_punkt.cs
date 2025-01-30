using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IydePersonal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class change_name_datatable_punkt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Punkts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Point",
                table: "Punkts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Point",
                table: "Punkts",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "92992ee9-d033-4362-91ac-10eedaf6c170", "AQAAAAIAAYagAAAAEHIiVh6LYXJab9Url+GWHlpOJp23JKLfC/FEbAFpO9HH4VUfA6hU8FAGZXHlNj9Z8w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "415ebe92-0beb-4b62-bcf3-19b7ee02193b", "AQAAAAIAAYagAAAAEIn6HOY71zN/HUYfoa66RxxCTsha2PmcZcOjrHXWnFSVjSn5yFHu8cJIT1M7KZeXiw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dbbec30c-daf0-4f71-97e0-53e542b73b30", "AQAAAAIAAYagAAAAEFLW0dqTAd3NhD8c7qKZFRZI2enX2LPgcAdAHJuZ+pVBsDt5037bKpgOdcC6pz0wCA==" });

            migrationBuilder.InsertData(
                table: "Punkts",
                columns: new[] { "Id", "Name", "Point" },
                values: new object[] { 1, "Nizami intizam pozmaq", 20 });
        }
    }
}
