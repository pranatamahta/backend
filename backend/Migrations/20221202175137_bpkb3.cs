using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    public partial class bpkb3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "bpkb_no",
                table: "tr_bpkb",
                newName: "bpkb_noo");

            migrationBuilder.RenameIndex(
                name: "IX_tr_bpkb_bpkb_no",
                table: "tr_bpkb",
                newName: "IX_tr_bpkb_bpkb_noo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "bpkb_noo",
                table: "tr_bpkb",
                newName: "bpkb_no");

            migrationBuilder.RenameIndex(
                name: "IX_tr_bpkb_bpkb_noo",
                table: "tr_bpkb",
                newName: "IX_tr_bpkb_bpkb_no");
        }
    }
}
