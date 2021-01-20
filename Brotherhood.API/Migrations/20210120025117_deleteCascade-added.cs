using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Brotherhood.API.Migrations
{
    public partial class deleteCascadeadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chapters_Comics_ComicId",
                table: "Chapters");

            migrationBuilder.DropTable(
                name: "PagesComics");

            migrationBuilder.CreateTable(
                name: "Pages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pages = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ChapterId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pages_Chapters_ChapterId",
                        column: x => x.ChapterId,
                        principalTable: "Chapters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pages_ChapterId",
                table: "Pages",
                column: "ChapterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chapters_Comics_ComicId",
                table: "Chapters",
                column: "ComicId",
                principalTable: "Comics",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chapters_Comics_ComicId",
                table: "Chapters");

            migrationBuilder.DropTable(
                name: "Pages");

            migrationBuilder.CreateTable(
                name: "PagesComics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChapterId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Pages = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PagesComics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PagesComics_Chapters_ChapterId",
                        column: x => x.ChapterId,
                        principalTable: "Chapters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PagesComics_ChapterId",
                table: "PagesComics",
                column: "ChapterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chapters_Comics_ComicId",
                table: "Chapters",
                column: "ComicId",
                principalTable: "Comics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
