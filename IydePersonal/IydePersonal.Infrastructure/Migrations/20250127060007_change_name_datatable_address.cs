using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IydePersonal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class change_name_datatable_address : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "Employees",
                newName: "Address");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Employees",
                newName: "Adress");

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
    }
}
