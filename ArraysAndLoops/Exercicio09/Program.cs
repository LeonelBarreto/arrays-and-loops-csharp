namespace Exercicio09;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Digite a quantidade de pedidos: ");
        int quantidade = int.Parse(Console.ReadLine());

        string[] pedidos = new string[quantidade];

        for (int i = 0; i < quantidade; i++)
        {
            pedidos[i] = "Pedido " + (i + 1);
        }

        Console.WriteLine(string.Join(", ", pedidos));

        List<string> listaPedidos = pedidos.ToList();

        Console.WriteLine();
        
        Console.Write("Digite o número do próximo pedido a ser inserido: ");
        int numeroPedido = int.Parse(Console.ReadLine());
        listaPedidos.Add($"Pedido {numeroPedido}");
        

        Console.WriteLine(string.Join(", ", listaPedidos));

        Console.WriteLine();
        Console.Write("Deseja retirar o primeiro pedido da lista? [s/n]: ");
        string retirarResposta = Console.ReadLine();

        Console.WriteLine();


        if (retirarResposta == "s")
        {
            listaPedidos.RemoveAt(0);
            Console.WriteLine(string.Join(", ", listaPedidos));
        }
        else if (retirarResposta == "n")
        {
            Console.WriteLine(string.Join(", ", listaPedidos));
        }
    }
}

