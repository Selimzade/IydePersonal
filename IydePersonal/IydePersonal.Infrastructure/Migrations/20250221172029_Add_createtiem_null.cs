using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IydePersonal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Add_createtiem_null : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
