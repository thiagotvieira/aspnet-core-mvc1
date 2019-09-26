using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesMvc.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_Seller_SelllerId",
                table: "SalesRecord");

            migrationBuilder.RenameColumn(
                name: "SelllerId",
                table: "SalesRecord",
                newName: "SellerId");

            migrationBuilder.RenameIndex(
                name: "IX_SalesRecord_SelllerId",
                table: "SalesRecord",
                newName: "IX_SalesRecord_SellerId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Seller",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Seller",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord");

            migrationBuilder.RenameColumn(
                name: "SellerId",
                table: "SalesRecord",
                newName: "SelllerId");

            migrationBuilder.RenameIndex(
                name: "IX_SalesRecord_SellerId",
                table: "SalesRecord",
                newName: "IX_SalesRecord_SelllerId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Seller",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Seller",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_Seller_SelllerId",
                table: "SalesRecord",
                column: "SelllerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
