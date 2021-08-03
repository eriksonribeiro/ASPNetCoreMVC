using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VidlyMVC.Migrations
{
    public partial class MovieChangeAndGenre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "Movie",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "Movie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Movie",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "Movie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movie_GenreId",
                table: "Movie",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Genre_GenreId",
                table: "Movie",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Genre_GenreId",
                table: "Movie");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropIndex(
                name: "IX_Movie_GenreId",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Movie");
        }
    }
}
