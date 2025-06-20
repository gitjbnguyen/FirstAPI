using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FirstAPI.Migrations
{
    /// <inheritdoc />
    public partial class bookdataadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "Author", "Title", "YearPublished" },
                values: new object[,]
                {
                    { 1, "George Orwell", "1984", 1949 },
                    { 2, "Harper Lee", "To Kill a Mockingbird", 1960 },
                    { 3, "F. Scott Fitzgerald", "The Great Gatsby", 1925 },
                    { 4, "John Steinbeck", "Of Mice and Men", 1937 },
                    { 5, "Jane Austen", "Pride and Prejudice", 1813 },
                    { 6, "J.D. Salinger", "The Catcher in the Rye", 1951 },
                    { 7, "Aldous Huxley", "Brave New World", 1932 },
                    { 8, "Ray Bradbury", "Fahrenheit 451", 1953 },
                    { 9, "J.R.R. Tolkien", "The Hobbit", 1937 },
                    { 10, "J.R.R. Tolkien", "The Lord of the Rings", 1954 },
                    { 11, "Paulo Coelho", "The Alchemist", 1988 },
                    { 12, "George Orwell", "Animal Farm", 1945 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 12);
        }
    }
}
