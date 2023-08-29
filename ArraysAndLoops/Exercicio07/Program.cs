namespace Exercicio07;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe quantos nomes irão compor o array: ");
        int quantidade = int.Parse(Console.ReadLine());

        string[] nomes = new string[quantidade];

        for (int i = 0; i < quantidade; i++)
        {
            nomes[i] = Console.ReadLine();
        }

        Console.WriteLine();

        Console.Write("Informe a letra para criar o filtro com as palavras que iniciam com ela: ");
        string letra = Console.ReadLine();

        Console.WriteLine();

        List<string> listaNomesFiltrados = new List<string>();

        foreach (var nome in nomes.Where(nome => nome.StartsWith(letra)))
        {
            listaNomesFiltrados.Add(nome);
        }

        Console.Write(string.Join(", ", listaNomesFiltrados));
    }
}

