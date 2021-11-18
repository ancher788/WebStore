using Microsoft.EntityFrameworkCore.Migrations;

namespace AnStore.Data.Migrations
{
    public partial class x1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "PushchasedGoods",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "PushchasedGoods");
        }
    }
}
