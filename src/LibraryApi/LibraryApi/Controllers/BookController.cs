using LibraryApi.Entities;
using LibraryApi.Models.Book;
using LibraryApi.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LIbraryApi.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{
    private readonly IBookRepository repository;

    public BookController(IBookRepository repository)
    {
        this.repository = repository;
    }

    [HttpPost]
    public IActionResult AddBook([FromBody] AddBookViewModel model)
    {
        Book newBook = repository.AddBook(model);
        return Ok(newBook);
    }

    [HttpGet("member-book-list")]
    public async Task<IActionResult> GetMemberBookList([FromBody] long memberId)
    {
        List<Book> bookList = await repository.GetMemberBooks(memberId);
        return Ok(bookList);
    }

    [HttpGet("find-book")]
    public async Task<IActionResult> FindBook([FromQuery] string searchTerm)
    {
        List<Book> bookList = await repository.FindBook(searchTerm);
        return Ok(bookList);
    }
}