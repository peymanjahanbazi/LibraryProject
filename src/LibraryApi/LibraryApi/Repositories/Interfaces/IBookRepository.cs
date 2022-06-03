using LibraryApi.Entities;
using LibraryApi.Models.Book;

namespace LibraryApi.Repositories.Interfaces;

public interface IBookRepository
{
    Book AddBook(AddBookViewModel model);

    Task<List<Book>> GetMemberBooks(long memberId);

    Task<List<Book>> FindBook(string searchTerm);
}