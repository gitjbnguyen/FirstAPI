using FirstAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
namespace FirstAPI.Data
{
    public class FirstAPIContext : DbContext
    {
        public FirstAPIContext(DbContextOptions<FirstAPIContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasData(
                new Book { ID = 1, Title = "1984", Author = "George Orwell", YearPublished = 1949 },
                new Book { ID = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", YearPublished = 1960 },
                new Book { ID = 3, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", YearPublished = 1925 },
                new Book { ID = 4, Title = "Of Mice and Men", Author = "John Steinbeck", YearPublished = 1937 },
                new Book { ID = 5, Title = "Pride and Prejudice", Author = "Jane Austen", YearPublished = 1813 },
                new Book { ID = 6, Title = "The Catcher in the Rye", Author = "J.D. Salinger", YearPublished = 1951 },
                new Book { ID = 7, Title = "Brave New World", Author = "Aldous Huxley", YearPublished = 1932 },
                new Book { ID = 8, Title = "Fahrenheit 451", Author = "Ray Bradbury", YearPublished = 1953 },
                new Book { ID = 9, Title = "The Hobbit", Author = "J.R.R. Tolkien", YearPublished = 1937 },
                new Book { ID = 10, Title = "The Lord of the Rings", Author = "J.R.R. Tolkien", YearPublished = 1954 },
                new Book { ID = 11, Title = "The Alchemist", Author = "Paulo Coelho", YearPublished = 1988 },
                new Book { ID = 12, Title = "Animal Farm", Author = "George Orwell", YearPublished = 1945 }
            );
        }
        public DbSet<Book> Books { get; set; }
    }
}
