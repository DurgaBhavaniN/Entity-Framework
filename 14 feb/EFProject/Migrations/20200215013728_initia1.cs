using Microsoft.EntityFrameworkCore.Migrations;

namespace EFProject.Migrations
{
    public partial class initia1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Item_id",
                table: "Item",
                newName: "Item_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Item_Id",
                table: "Item",
                newName: "Item_id");
        }
    }
}
