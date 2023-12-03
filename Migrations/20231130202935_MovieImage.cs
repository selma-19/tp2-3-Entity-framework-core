using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tp2.Migrations
{
    public partial class MovieImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "MovieAdded",
                table: "Movies",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "GenreName" },
                values: new object[] { 4, null });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "GenreName" },
                values: new object[] { 5, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "MovieAdded",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Movies");
        }
    }
}
