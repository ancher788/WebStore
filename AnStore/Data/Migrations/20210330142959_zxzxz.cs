using Microsoft.EntityFrameworkCore.Migrations;

namespace AnStore.Data.Migrations
{
    public partial class zxzxz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GoodsId",
                table: "Operations");

            migrationBuilder.DropColumn(
                name: "JournalId",
                table: "Operations");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Journals");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GoodsId",
                table: "Operations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "JournalId",
                table: "Operations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Journals",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
