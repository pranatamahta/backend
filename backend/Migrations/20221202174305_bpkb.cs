using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    public partial class bpkb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ms_storage_location",
                columns: table => new
                {
                    location_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    location_name = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ms_storage_location", x => x.location_id);
                });

            migrationBuilder.CreateTable(
                name: "tr_bpkb",
                columns: table => new
                {
                    agreement_number = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    bpkb_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    branch_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bpkb_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    faktur_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    faktur_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    location_id = table.Column<int>(type: "int", nullable: false),
                    police_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bpkb_date_in = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tr_bpkb", x => x.agreement_number);
                    table.ForeignKey(
                        name: "FK_tr_bpkb_ms_storage_location_location_id",
                        column: x => x.location_id,
                        principalTable: "ms_storage_location",
                        principalColumn: "location_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ms_storage_location_location_name",
                table: "ms_storage_location",
                column: "location_name");

            migrationBuilder.CreateIndex(
                name: "IX_tr_bpkb_location_id",
                table: "tr_bpkb",
                column: "location_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tr_bpkb");

            migrationBuilder.DropTable(
                name: "ms_storage_location");
        }
    }
}
