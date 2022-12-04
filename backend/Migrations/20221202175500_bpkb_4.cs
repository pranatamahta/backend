using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    public partial class bpkb_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "bpkb_noo",
                table: "tr_bpkb",
                newName: "no_bpkb");

            migrationBuilder.RenameIndex(
                name: "IX_tr_bpkb_bpkb_noo",
                table: "tr_bpkb",
                newName: "IX_tr_bpkb_no_bpkb");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "no_bpkb",
                table: "tr_bpkb",
                newName: "bpkb_noo");

            migrationBuilder.RenameIndex(
                name: "IX_tr_bpkb_no_bpkb",
                table: "tr_bpkb",
                newName: "IX_tr_bpkb_bpkb_noo");
        }
    }
}
