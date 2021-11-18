using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnStore.Data.Migrations
{
    public partial class vbn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PushchasedGoodsId",
                table: "Goods",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PushchasedGoods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateSale = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CountGoodsSold = table.Column<double>(type: "float", nullable: false),
                    GoodsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PushchasedGoods", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Goods_PushchasedGoods_PushchasedGoodsId",
                table: "Goods");

            migrationBuilder.DropTable(
                name: "PushchasedGoods");

            migrationBuilder.DropIndex(
                name: "IX_Goods_PushchasedGoodsId",
                table: "Goods");

            migrationBuilder.DropColumn(
                name: "PushchasedGoodsId",
                table: "Goods");
        }
    }
}
