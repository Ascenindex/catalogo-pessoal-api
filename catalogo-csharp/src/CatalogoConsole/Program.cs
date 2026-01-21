using CatalogoConsole.Models;
using CatalogoConsole.Services;

class Program
{
    static void Main()
    {
        BookService bookService = new BookService();
        bookService.AddItem(new Book { Id = 1, Title = "1984", Author = "George Orwell" });
        bookService.AddItem(new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee" });
        
        foreach (var book in bookService.GetAllItems())
        {
            Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Author: {book.Author}");
        }

        // search book by id
        bookService.GetItemById(2);
        var bookById = bookService.GetItemById(2);
        Console.WriteLine(bookById != null
            ? $"Found Book - ID: {bookById.Id}, Title: {bookById.Title}, Author: {bookById.Author}"
            : "Book not found.");

        // remove book by id
        bool isRemoved = bookService.DeleteItem(2);
        Console.WriteLine(isRemoved ? "Book removed successfully." : "Book not found for removal.");
    }
}