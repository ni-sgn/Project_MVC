using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LawSuitDictionaries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    HasStatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LawSuitDictionaries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemDictionaries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    HasPosition = table.Column<bool>(nullable: false),
                    HasUserType = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemDictionaries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PersonalId = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    CompanyId = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    TypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                    table.ForeignKey(
                        name: "FK_People_PersonTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "PersonTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SystemUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonalId = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    TypeId = table.Column<int>(nullable: false),
                    PositionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemUsers_SystemDictionaries_PositionId",
                        column: x => x.PositionId,
                        principalTable: "SystemDictionaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemUsers_SystemDictionaries_TypeId",
                        column: x => x.TypeId,
                        principalTable: "SystemDictionaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LawSuits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    PersonId = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LawSuits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LawSuits_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LawSuits_LawSuitDictionaries_StatusId",
                        column: x => x.StatusId,
                        principalTable: "LawSuitDictionaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "LawSuitDictionaries",
                columns: new[] { "Id", "HasStatus", "Name" },
                values: new object[,]
                {
                    { 1, true, "Ongoing" },
                    { 2, true, "Finished" },
                    { 3, true, "Rejected" },
                    { 4, true, "Stalled" }
                });

            migrationBuilder.InsertData(
                table: "PersonTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Private" },
                    { 2, "Legal" }
                });

            migrationBuilder.InsertData(
                table: "SystemDictionaries",
                columns: new[] { "Id", "HasPosition", "HasUserType", "Name" },
                values: new object[,]
                {
                    { 1, true, false, "System Administrator" },
                    { 2, true, false, "Judge" },
                    { 3, false, true, "Admin" },
                    { 4, false, true, "User" }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "CompanyId", "CompanyName", "FirstName", "LastName", "PersonalId", "PhoneNumber", "TypeId" },
                values: new object[] { 1, "Tbilisi", null, null, "person1", "lastname1", "010203030", "555929292", 1 });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "BirthDate", "FirstName", "LastName", "PersonalId", "PositionId", "TypeId" },
                values: new object[] { 1, new DateTime(1992, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Name1", "Lastnam1", "123123112", 1, 3 });

            migrationBuilder.InsertData(
                table: "LawSuits",
                columns: new[] { "Id", "Body", "CreationDate", "ExpirationDate", "PersonId", "StatusId", "Title" },
                values: new object[] { 1, "This is a lawsuit", new DateTime(1992, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "I don't like when someone violates my freedom" });

            migrationBuilder.CreateIndex(
                name: "IX_LawSuits_PersonId",
                table: "LawSuits",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_LawSuits_StatusId",
                table: "LawSuits",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_People_TypeId",
                table: "People",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemUsers_PositionId",
                table: "SystemUsers",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemUsers_TypeId",
                table: "SystemUsers",
                column: "TypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LawSuits");

            migrationBuilder.DropTable(
                name: "SystemUsers");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "LawSuitDictionaries");

            migrationBuilder.DropTable(
                name: "SystemDictionaries");

            migrationBuilder.DropTable(
                name: "PersonTypes");
        }
    }
}
