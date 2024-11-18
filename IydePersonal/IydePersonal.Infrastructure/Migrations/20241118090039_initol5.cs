using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IydePersonal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initol5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d9d61011-cca7-42db-81ec-c85ec26fc6c4", "AQAAAAIAAYagAAAAEIDRzl1ktWlnns+TATT1er7CCS6hYKrb2FxHo42KpwazlbcAhbr3AbqLzpyXao5QFQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b8186301-a0d3-4ccd-8c05-f72f4540392a", "AQAAAAIAAYagAAAAEAgGMbB36FjZV4dQypYD5xQ3/am31lsktpl2t8xRK00iIwMDvkqE/AfRIddADpxbiw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cefcc2c8-73f1-4f4d-b0fa-2a16dc3ff373", "AQAAAAIAAYagAAAAEO/eTnpp7PK7ilKsaaj9GFkrYQNicVIYbiroyN5FNCspmlF1pqZv08uqHiH6scMD4w==" });

            migrationBuilder.UpdateData(
                table: "EmployeePunkts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 18, 12, 0, 38, 719, DateTimeKind.Local).AddTicks(2811));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "83a19c77-00dd-40f5-bcf4-a512132ad5fe", "AQAAAAIAAYagAAAAEGSFyQ/WvyJ26SqKoVGlIynmJdmEyezfGBpJ86wjWDl8ORRxGusJh8k6TauarEVUXw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d825ecd0-3ca6-4cfb-a5b0-d32ae44d1342", "AQAAAAIAAYagAAAAEOP6ukT19zr/nry5vFBWhgJkRGED43R4l5CtirNwn8GTDbAwcdovZh+TfjgXdr2JlQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9f96a3a1-71d1-4da1-a4fd-bd17bb55b549", "AQAAAAIAAYagAAAAEKvxMGU1AlnkcAn9Bv3JOx1YvW6uhq9lDdvBIOv/TL+1enYS1KiGQ+PoHW8x0R0SdA==" });

            migrationBuilder.UpdateData(
                table: "EmployeePunkts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 14, 13, 12, 35, 178, DateTimeKind.Local).AddTicks(7719));
        }
    }
}
