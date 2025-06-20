﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FirstAPI.Models;
using FirstAPI.Data;
using Microsoft.EntityFrameworkCore;
namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        //static private List<Book> books = new List<Book>
        //{
        //    new Book { ID = 1, Title = "1984", Author = "George Orwell", YearPublished = 1949 },
        //    new Book { ID = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", YearPublished = 1960 },
        //    new Book { ID = 3, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", YearPublished = 1925 },
        //    new Book { ID = 4, Title = "Of Mice and Men", Author = "John Steinbeck", YearPublished = 1937 },
        //    new Book { ID = 5, Title = "Pride and Prejudice", Author = "Jane Austen", YearPublished = 1813 },
        //    new Book { ID = 6, Title = "The Catcher in the Rye", Author = "J.D. Salinger", YearPublished = 1951 },
        //    new Book { ID = 7, Title = "Brave New World", Author = "Aldous Huxley", YearPublished = 1932 },
        //    new Book { ID = 8, Title = "Fahrenheit 451", Author = "Ray Bradbury", YearPublished = 1953 },
        //    new Book { ID = 9, Title = "The Hobbit", Author = "J.R.R. Tolkien", YearPublished = 1937 },
        //    new Book { ID = 10, Title = "The Lord of the Rings", Author = "J.R.R. Tolkien", YearPublished = 1954 },
        //    new Book { ID = 11, Title = "The Alchemist", Author = "Paulo Coelho", YearPublished = 1988 },
        //    new Book { ID = 12, Title = "Animal Farm", Author = "George Orwell", YearPublished = 1945 }
        //};

        private readonly FirstAPIContext _context;

        public BooksController(FirstAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetBooks()
        {
            return Ok(await _context.Books.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBookById(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
                return NotFound();

            return Ok(book);
        }
        [HttpPost]
        public async Task<ActionResult<Book>> AddBook(Book newBook)
        {
            if (newBook == null)
                return BadRequest();

            _context.Books.Add(newBook);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetBookById), new { id = newBook.ID }, newBook);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook(int id, Book updatedBook)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
                return NotFound();

            book.ID = updatedBook.ID;
            book.Title = updatedBook.Title;
            book.Author = updatedBook.Author;
            book.YearPublished = updatedBook.YearPublished;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
                return NotFound();

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
