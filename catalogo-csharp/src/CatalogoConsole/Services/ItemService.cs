using CatalogoConsole.Models;

namespace CatalogoConsole.Services;

public class ItemService : IItemService
{
    private List<Item> _items = new List<Item>();
    private int _nextId = 1;

    public ItemService()
    {
        // Inicializar com alguns itens (opcional)
        _items.Add(new Item(_nextId++, "Item 1", true));
        _items.Add(new Item(_nextId++, "Item 2", false));
    }

    public List<Item> GetAllItems()
    {
        return _items;
    }

    public Item? GetItemById(int id)
    {
        return _items.FirstOrDefault(i => i.Id == id);
    }

    public void AddItem(Item item)
    {
        item.Id = _nextId++;
        _items.Add(item);
    }

    public void UpdateItem(Item item)
    {
        var existingItem = GetItemById(item.Id);
        if (existingItem != null)
        {
            existingItem.Name = item.Name;
            existingItem.Status = item.Status;
        }
    }

    public void DeleteItem(int id)
    {
        var item = GetItemById(id);
        if (item != null)
        {
            _items.Remove(item);
        }
    }

    public void ToggleItemStatus(int id)
    {
        var item = GetItemById(id);
        if (item != null)
        {
            item.Status = !item.Status;
        }
    }
}