using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IydePersonal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class add_invertar_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Supplier = table.Column<int>(type: "int", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inventories_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c50970d3-b661-4248-978f-d5d210154aa4", "AQAAAAIAAYagAAAAEMYuiWgfQt++giBjpMUS9kI5XKFTtSHdJg7sxfnxE6XcOLp2vHcmcl+vonJbbii8+g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fc5eb5fc-4429-4252-8330-93626682ff5c", "AQAAAAIAAYagAAAAEPUFc9ePrLd8zytVqP+sez82AsUITlv4a1HGyVwaNOCKPQBG+XkIaeSLcD2nrWfbaQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "60db5f86-7bf3-4667-973f-29bfabbf561d", "AQAAAAIAAYagAAAAECLdDUZ11RwwgktafFn4K2XxENAWSa3QskU19XlgHX68nCwS5PcvlrdcjyxwgRdvAQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_StoreId",
                table: "Inventories",
                column: "StoreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6574482c-9dbc-42ee-9d28-e35fccb0bbae", "AQAAAAIAAYagAAAAEFZAXVer1gcatQtzPqsN3jmxMRfUP3VfMNYqEzqMZW9SSydq3b3OJnkoXnS8mNrW/A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d77d10f5-7fa0-4f3b-a74d-ea7ca17d89f4", "AQAAAAIAAYagAAAAEKy8scTQLhcZ5t80bQXHL/05jCht8yDhQJUkOgAJ0N5puI826bFD6i3RXOJs5Y2ynw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f0e36902-4fc2-431d-b9d2-1475541a199c", "AQAAAAIAAYagAAAAEDuEpVNMfPZOAtZFVSZ0VMvujdV07l1V4ivYN8lDz++oPBnvXiSo1d8tIy3Q8hGWLw==" });
        }
    }
}
