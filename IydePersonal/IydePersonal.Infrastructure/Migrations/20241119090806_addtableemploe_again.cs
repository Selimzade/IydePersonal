using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IydePersonal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addtableemploe_again : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b042f06a-63cb-443a-a074-8107b30d3f8b", "AQAAAAIAAYagAAAAEK2y7AL4wWyc+hxBDvxaidYpNRTPClrG/524t525sNwmXq/L6drjGnEhOFS2wBsqBA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "521d84b4-0a62-4f59-8136-894603d99542", "AQAAAAIAAYagAAAAEH705dyyeZD+HkEBilldSf8t1j2IC23EtdnouSNjsLeZ5Sr9bVA3yM9qolzBtBsEig==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "75d379e7-a085-4558-a2bf-98b040399b1b", "AQAAAAIAAYagAAAAEK1D7w6LO+YzE7QQ660icg0xI3Gy3Hv705JjKYce5bQf2l6KRi3Foh3dAEv9GL1ucg==" });

            migrationBuilder.UpdateData(
                table: "EmployeePunkts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 19, 12, 8, 5, 528, DateTimeKind.Local).AddTicks(7463));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
