using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IydePersonal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class change_emptable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "53da27da-dcdc-4eaa-83a0-4d883e327a00", "AQAAAAIAAYagAAAAEAn/3Jd423K/S7U1AEra8CiTRMaEtAZOcbGUI4HYZMO34ti3bGFMpvLsf/Fe1qCO1g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ceecc650-bb21-437d-9c50-2433861707b7", "AQAAAAIAAYagAAAAEJqSubftrdbvvS/0eG/FCIxNcAEof1AfdUbnDj7HeplLz0xih+im7RuElRvSvsFSZA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d849de46-c930-44d9-be13-eb5d97863536", "AQAAAAIAAYagAAAAEOvCjHMnRJrMlYCzfSCaI4EnTm4iikYcAGgI0wS44Q/X1+aHrxX9L3TBaV3IR+36qw==" });

            migrationBuilder.UpdateData(
                table: "EmployeePunkts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 19, 13, 7, 10, 782, DateTimeKind.Local).AddTicks(3439));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
