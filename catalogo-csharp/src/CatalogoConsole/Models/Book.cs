namespace CatalogoConsole.Models;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public bool Available { get; set; }


    // empty constructor
    public Book() { }


    public Book(int id, string title, string author, bool available)
    {
        this.Id = id;
        this.Title = title;
        this.Author = author;
        this.Available = available;
    }

}