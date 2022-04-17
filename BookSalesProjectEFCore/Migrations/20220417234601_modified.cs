using Microsoft.EntityFrameworkCore.Migrations;

namespace BookSalesProjectEFCore.Migrations
{
    public partial class modified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookPublishers_Publishers_PublisherId",
                table: "BookPublishers");

            migrationBuilder.DropColumn(
                name: "PublishId",
                table: "BookPublishers");

            migrationBuilder.AlterColumn<int>(
                name: "PublisherId",
                table: "BookPublishers",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BookPublishers_Publishers_PublisherId",
                table: "BookPublishers",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookPublishers_Publishers_PublisherId",
                table: "BookPublishers");

            migrationBuilder.AlterColumn<int>(
                name: "PublisherId",
                table: "BookPublishers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "PublishId",
                table: "BookPublishers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_BookPublishers_Publishers_PublisherId",
                table: "BookPublishers",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
