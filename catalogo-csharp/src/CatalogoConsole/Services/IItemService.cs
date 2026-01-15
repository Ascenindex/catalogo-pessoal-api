using CatalogoConsole.Models;

namespace CatalogoConsole.Services;

public interface IItemService
{
    List<Item> GetAllItems();
    Item? GetItemById(int id); // Use nullable para indicar que pode retornar null
    void AddItem(Item item);
    void UpdateItem(Item item);
    void DeleteItem(int id);
    void ToggleItemStatus(int id);
}