using CatalogoConsole.Models;

namespace CatalogoConsole.Services;

public class BookService : IBookService
{
   private List<Book> books = new List<Book>();
   
    public List<Book> GetAllItems()
    {
        return books.ToList();
    }

    public Book? GetItemById(int id)
    {
        return books.FirstOrDefault(b => b.Id == id);
    }

    public void AddItem(Book book)
    {
        books.Add(book);
    }

    public bool DeleteItem(int id)
    {
        var book = GetItemById(id);
        return book != null && books.Remove(book);
    }


}