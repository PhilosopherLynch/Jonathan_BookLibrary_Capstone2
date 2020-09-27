using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace capstone.Data.Migrations
{
    public partial class BookData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Chapters", "Completed", "Genre", "Title", "UserId", "YearOfPublish" },
                values: new object[] { 1, "C.S. Lewis", 15, true, "Fantasy", "Prince Caspian", "2845a7e7-b0cc-4500-a672-10d476d09ac4", new DateTime(1951, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Chapters", "Completed", "Genre", "Title", "UserId", "YearOfPublish" },
                values: new object[] { 2, "J.R.R. Tolkien", 19, true, "Fantasy", "The Hobbit", "2845a7e7-b0cc-4500-a672-10d476d09ac4", new DateTime(1939, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Chapters", "Completed", "Genre", "Title", "UserId", "YearOfPublish" },
                values: new object[] { 3, "Robert A. Heinlin", 14, true, "Sci-fi", "Starship Troopers", "2845a7e7-b0cc-4500-a672-10d476d09ac4", new DateTime(1959, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Chapters", "Completed", "Genre", "Title", "UserId", "YearOfPublish" },
                values: new object[] { 4, "Davic Platt", 9, false, "Christian", "Radical", "2845a7e7-b0cc-4500-a672-10d476d09ac4", new DateTime(2010, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
