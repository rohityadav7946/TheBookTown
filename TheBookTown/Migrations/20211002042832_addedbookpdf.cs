using Microsoft.EntityFrameworkCore.Migrations;

namespace TheBookTown.Migrations
{
    public partial class addedbookpdf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BookPdfUrlPath",
                table: "Books",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Genre", "Title" },
                values: new object[] { "James Clear", 8, "Atomic Habits" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Genre", "Title" },
                values: new object[] { "Paulo Coelho", 3, " The Alchemist" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookPdfUrlPath",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Genre", "Title" },
                values: new object[] { "mark@gmail.com", 2, "Mark" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Genre", "Title" },
                values: new object[] { "marrry@gmail.com", 1, "Marry" });
        }
    }
}
