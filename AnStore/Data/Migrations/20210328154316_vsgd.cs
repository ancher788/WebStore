using Microsoft.EntityFrameworkCore.Migrations;

namespace AnStore.Data.Migrations
{
    public partial class vsgd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Goods_PushchasedGoods_PushchasedGoodsId",
                table: "Goods");

            migrationBuilder.DropIndex(
                name: "IX_Goods_PushchasedGoodsId",
                table: "Goods");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "PushchasedGoods");

            migrationBuilder.DropColumn(
                name: "GoodsId",
                table: "PushchasedGoods");

            migrationBuilder.DropColumn(
                name: "PushchasedGoodsId",
                table: "Goods");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "PushchasedGoods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GoodsId",
                table: "PushchasedGoods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PushchasedGoodsId",
                table: "Goods",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Goods_PushchasedGoodsId",
                table: "Goods",
                column: "PushchasedGoodsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Goods_PushchasedGoods_PushchasedGoodsId",
                table: "Goods",
                column: "PushchasedGoodsId",
                principalTable: "PushchasedGoods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
