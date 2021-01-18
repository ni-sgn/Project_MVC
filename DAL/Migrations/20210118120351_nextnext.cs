using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class nextnext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LawSuits_People_PersonId",
                table: "LawSuits");

            migrationBuilder.AddForeignKey(
                name: "FK_LawSuits_People_PersonId",
                table: "LawSuits",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LawSuits_People_PersonId",
                table: "LawSuits");

            migrationBuilder.AddForeignKey(
                name: "FK_LawSuits_People_PersonId",
                table: "LawSuits",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
