using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnStore.Data.Migrations
{
    public partial class zzz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PushchasedGoods");

            migrationBuilder.AddColumn<int>(
                name: "OperationId",
                table: "Goods",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Operations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SumGoods = table.Column<int>(type: "int", nullable: false),
                    CountGoods = table.Column<int>(type: "int", nullable: false),
                    JournalId = table.Column<int>(type: "int", nullable: false),
                    GoodsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Journals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataSold = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoldSum = table.Column<int>(type: "int", nullable: false),
                    SendGoods = table.Column<bool>(type: "bit", nullable: false),
                    Sold = table.Column<bool>(type: "bit", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    OperationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Journals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Journals_Operations_OperationId",
                        column: x => x.OperationId,
                        principalTable: "Operations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstnameCustomer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastnameCustomer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumberCustomer = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    JournalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Journals_JournalId",
                        column: x => x.JournalId,
                        principalTable: "Journals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Goods_OperationId",
                table: "Goods",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_JournalId",
                table: "Customers",
                column: "JournalId");

            migrationBuilder.CreateIndex(
                name: "IX_Journals_OperationId",
                table: "Journals",
                column: "OperationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Goods_Operations_OperationId",
                table: "Goods",
                column: "OperationId",
                principalTable: "Operations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Goods_Operations_OperationId",
                table: "Goods");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Journals");

            migrationBuilder.DropTable(
                name: "Operations");

            migrationBuilder.DropIndex(
                name: "IX_Goods_OperationId",
                table: "Goods");

            migrationBuilder.DropColumn(
                name: "OperationId",
                table: "Goods");

            migrationBuilder.CreateTable(
                name: "PushchasedGoods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountGoodsSold = table.Column<double>(type: "float", nullable: false),
                    DateSale = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PushchasedGoods", x => x.Id);
                });
        }
    }
}
