using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class slightly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_PersonTypes_TypeId",
                table: "People");

            migrationBuilder.DropTable(
                name: "PersonTypes");

            migrationBuilder.DropColumn(
                name: "Body",
                table: "LawSuits");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "LawSuits");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "LawSuits");

            migrationBuilder.AddColumn<DateTime>(
                name: "RegistrationDate",
                table: "LawSuits",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "HasPersonType",
                table: "LawSuitDictionaries",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "LawSuitDictionaries",
                columns: new[] { "Id", "HasCity", "HasPersonType", "HasPhoneType", "HasStatus", "Name" },
                values: new object[] { 9, false, true, false, false, "Private" });

            migrationBuilder.InsertData(
                table: "LawSuitDictionaries",
                columns: new[] { "Id", "HasCity", "HasPersonType", "HasPhoneType", "HasStatus", "Name" },
                values: new object[] { 10, false, true, false, false, "Legal" });

            migrationBuilder.UpdateData(
                table: "LawSuits",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(1992, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "TypeId",
                value: 9);

            migrationBuilder.AddForeignKey(
                name: "FK_People_LawSuitDictionaries_TypeId",
                table: "People",
                column: "TypeId",
                principalTable: "LawSuitDictionaries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_LawSuitDictionaries_TypeId",
                table: "People");

            migrationBuilder.DeleteData(
                table: "LawSuitDictionaries",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "LawSuitDictionaries",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "RegistrationDate",
                table: "LawSuits");

            migrationBuilder.DropColumn(
                name: "HasPersonType",
                table: "LawSuitDictionaries");

            migrationBuilder.AddColumn<string>(
                name: "Body",
                table: "LawSuits",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "LawSuits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "LawSuits",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PersonTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonTypes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "LawSuits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Body", "CreationDate", "Title" },
                values: new object[] { "This is a lawsuit", new DateTime(1992, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "I don't like when someone violates my freedom" });

            migrationBuilder.InsertData(
                table: "PersonTypes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Legal" });

            migrationBuilder.InsertData(
                table: "PersonTypes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Private" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "TypeId",
                value: 1);

            migrationBuilder.AddForeignKey(
                name: "FK_People_PersonTypes_TypeId",
                table: "People",
                column: "TypeId",
                principalTable: "PersonTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
