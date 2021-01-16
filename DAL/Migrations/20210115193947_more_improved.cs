using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class more_improved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 1,
                column: "TypeId",
                value: 5);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 1,
                column: "TypeId",
                value: 1);
        }
    }
}
