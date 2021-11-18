using Microsoft.EntityFrameworkCore.Migrations;

namespace AnStore.Data.Migrations
{
    public partial class vjni : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Goods",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Imagine",
                table: "Goods",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Goods");

            migrationBuilder.DropColumn(
                name: "Imagine",
                table: "Goods");
        }
    }
}
