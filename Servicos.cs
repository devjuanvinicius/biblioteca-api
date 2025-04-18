using Biblioteca.Models;

namespace Biblioteca;

public class Servicos
{
    private List<Book> books = new List<Book>();

    public void createBook(Book book)
    {
        books.Add(book);
    }

    public List<Book> GetAllBooks()
    {
        return books;
    }

    public void editBook(Book newInfosBook)
    {
        books.ForEach(book => {
            if(book.Id == newInfosBook.Id)
            {
                book.Titulo = newInfosBook.Titulo;
                book.Autor = newInfosBook.Autor;
                book.Genero = newInfosBook.Genero;
                book.Preco = newInfosBook.Preco;
                book.QtdEstoque = newInfosBook.QtdEstoque;
            }
        });
    }

    public void deleteBook(int bookId)
    {
        books.ForEach(book =>
        {
            if(bookId == book.Id)
            {
                books.Remove(book);
            }
        });
    }
}

