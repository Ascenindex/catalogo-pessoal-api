namespace CatalogoConsole.Models;
public class Item
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool Status { get; set; }

    public Item(int id, string name, bool status)
    {
        this.Id = id;
        this.Name = name;
        this.Status = status;
    }
}