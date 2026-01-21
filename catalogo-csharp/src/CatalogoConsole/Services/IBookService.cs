using CatalogoConsole.Models;

namespace CatalogoConsole.Services;

public interface IBookService
{
    List<Book> GetAllItems();
    Book? GetItemById(int id); // Use nullable para indicar que pode retornar null
    void AddItem(Book books);
    bool DeleteItem(int id);
}