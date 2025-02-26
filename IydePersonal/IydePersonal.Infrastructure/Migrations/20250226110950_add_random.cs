using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IydePersonal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class add_random : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Codebar",
                table: "Inventories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ac10ad17-4db2-4e0c-8814-2b66feff4eae", "AQAAAAIAAYagAAAAENiVKFuJHmL69ekhaMID+Rhop3VoMgS1V7cMa+IUMxu0eXdgCmy0rhgtFapYTH04Pw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b972afe9-6eb5-4383-af81-801cadbbe790", "AQAAAAIAAYagAAAAEPhN6Gn42nHoEaiQSkzAAOPNVCVf2G2tlMcUwqbtGzCtlqkpqR1/VNSa6y6MY0l26g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0b9d7d67-3f8a-4994-91e8-5abd62cbc90e", "AQAAAAIAAYagAAAAEA9DIO4YMAkKsN304IsU4E986blYgTnQ8skt3LwEnHciHVrSV24mY4tsI+6753RLOA==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Codebar",
                table: "Inventories",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "64e80161-8d8c-466c-ace3-66dc2a1f5e00", "AQAAAAIAAYagAAAAEDcOsRuNu2fOWoEhIPLELv4oodd2R/IZt5eAwFIUTTENdPXYWvu+S9EpcDlyHkVs1Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "69e1c00d-a895-4641-a675-78d28fab4f2c", "AQAAAAIAAYagAAAAED0/aWeYTA5dUi7Ga6kBuDKO9OOE2++PHF0lx9YW3O5mM6hDYFZ+djX2EGwqNCLANQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3d831e48-f92d-4c9a-a1db-fe59a299d934", "AQAAAAIAAYagAAAAECA75WC9ooTwSeXwO8izWAvCfNfNHJTxE/ewvx8hTyfDDbTWahtyBKPfSNWOOCNCyQ==" });
        }
    }
}
