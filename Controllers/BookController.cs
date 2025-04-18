using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    private readonly Servicos _services;

    public BookController(Servicos services)
    {
        _services = services;
    }

    [HttpPost("createBook")]
    public IActionResult createBook([FromBody] Book newBook)
    {
        if (newBook == null)
        {
            return BadRequest("Livro não pode ser nulo");
        }

        _services.createBook(newBook);

        return Created();
    }

    [HttpGet("getAllBooks")]
    public IActionResult getAllBooks()
    {
        List<Book> books = new List<Book>();

        books = _services.GetAllBooks();

        return Ok(books);
    }

    [HttpPut("editBooks")]
    public IActionResult editBook([FromBody] Book editedBook)
    {
        _services.editBook(editedBook);

        return Ok("Livro editado");
    }

    [HttpPost("deleteBook")]
    public IActionResult deleteBook(int bookId)
    {
        _services.deleteBook(bookId);

        return Ok("Livro excluido");
    }
}
