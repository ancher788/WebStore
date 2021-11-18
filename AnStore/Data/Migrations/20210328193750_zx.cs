using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnStore.Data.Migrations
{
    public partial class zx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sold",
                table: "Journals",
                newName: "IsSold");

            migrationBuilder.RenameColumn(
                name: "SendGoods",
                table: "Journals",
                newName: "IsSendGoods");

            migrationBuilder.AlterColumn<double>(
                name: "SumGoods",
                table: "Operations",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "CountGoods",
                table: "Operations",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "SoldSum",
                table: "Journals",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataSold",
                table: "Journals",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsSold",
                table: "Journals",
                newName: "Sold");

            migrationBuilder.RenameColumn(
                name: "IsSendGoods",
                table: "Journals",
                newName: "SendGoods");

            migrationBuilder.AlterColumn<int>(
                name: "SumGoods",
                table: "Operations",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "CountGoods",
                table: "Operations",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "SoldSum",
                table: "Journals",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataSold",
                table: "Journals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
