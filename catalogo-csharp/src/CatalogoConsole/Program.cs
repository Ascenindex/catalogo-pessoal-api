namespace CatalogoConsole;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Projeto Catalogo - Dia 1: Modelo criado.");
        // Apenas para teste de compilação
        var itemTeste = new Models.Item(1, "Item Teste", true);
        Console.WriteLine($"Item criado: {itemTeste.Name}");
    }
}