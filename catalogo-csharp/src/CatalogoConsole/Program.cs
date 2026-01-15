using CatalogoConsole.Models;
using CatalogoConsole.Services;

class Program
{
    static void Main()
    {
        IItemService itemService = new ItemService();
        
        // Testar o serviço
        Console.WriteLine("Itens iniciais:");
        foreach (var item in itemService.GetAllItems())
        {
            Console.WriteLine($"- {item.Id}: {item.Name} (Ativo: {item.Status})");
        }
        
        // Adicionar novo item
        itemService.AddItem(new Item(0, "Novo Item 3", true));
        
        Console.WriteLine("\nApós adicionar novo item:");
        foreach (var item in itemService.GetAllItems())
        {
            Console.WriteLine($"- {item.Id}: {item.Name} (Ativo: {item.Status})");
        }
    }
}