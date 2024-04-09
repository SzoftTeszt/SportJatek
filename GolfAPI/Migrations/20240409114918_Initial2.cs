using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GolfAPI.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Result_PlayerId",
                table: "Result",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Result_Player_PlayerId",
                table: "Result",
                column: "PlayerId",
                principalTable: "Player",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Result_Player_PlayerId",
                table: "Result");

            migrationBuilder.DropIndex(
                name: "IX_Result_PlayerId",
                table: "Result");
        }
    }
}
