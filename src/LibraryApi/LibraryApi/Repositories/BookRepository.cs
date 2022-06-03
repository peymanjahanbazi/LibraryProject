using AutoMapper;
using LibraryApi.Data;
using LibraryApi.Entities;
using LibraryApi.Models.Book;
using LibraryApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibraryApi.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryDbContext context;
        private readonly IMapper mapper;

        public BookRepository(LibraryDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public Book AddBook(AddBookViewModel model)
        {
            var newBook = mapper.Map<Book>(model);
            context.Books.Add(newBook);
            context.SaveChanges();
            return newBook;
        }

        public async Task<List<Book>> FindBook(string searchTerm)
        {
            var bookList = await context.Books
                .Where(x => x.Title.Contains(searchTerm))
                .Select(x => x)
                .OrderByDescending(x => x.PublishYear)
                .Take(10)
                .ToListAsync();
            return bookList;
        }

        public async Task<List<Book>> GetMemberBooks(long memberId)
        {
            var bookList = await context.Borrows
                .Include(x => x.Book)
                .Where(x => x.MemberId == memberId && x.ReturnDate == null)
                .Select(x => x.Book)
                .ToListAsync();
            return bookList;
        }
    }
}