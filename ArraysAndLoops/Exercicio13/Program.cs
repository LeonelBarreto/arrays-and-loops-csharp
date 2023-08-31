namespace Exercicio13;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a quantidade de disjuntores que serão inseridos: ");
        int quantidade = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Digite ligado ou desligado:");

        string[] disjuntores = new string[quantidade];

        for (int i = 0; i < quantidade; i++)
        {
            Console.Write($"Disjuntor {i + 1}: ");
            disjuntores[i] = Console.ReadLine().ToLower();
        }

        List<string> disjuntoresLista = disjuntores.ToList();
        Console.WriteLine("");
        Console.Write("Disjuntores: ");
        Console.Write(string.Join(", ", disjuntoresLista));

        List<int> disjuntoresLigados = new List<int>();
        List<int> disjuntoresDesligados = new List<int>();

        for (int i = 0; i < disjuntoresLista.Count; i++)
        {
            if (disjuntoresLista[i] == "ligado")
            {
                disjuntoresLigados.Add(i);
            }
        }

        for (int i = 0; i < disjuntoresLista.Count; i++)
        {
            if (disjuntoresLista[i] == "desligado")
            {
                disjuntoresDesligados.Add(i);
            }
        }

        Console.WriteLine();

        Console.Write("Você deseja saber qual status dos disjuntores? Digite 'ligado'ou 'desligado': ");
        string respostaStatus = Console.ReadLine().ToLower();
        Console.WriteLine();

        if (respostaStatus == "ligado")
        {
            Console.Write("Disjuntores ligados nas posições: ");
            Console.Write(string.Join(", ", disjuntoresLigados));
        }
        else
        {
            Console.Write("Disjuntores ligados nas posições: ");
            Console.Write(string.Join(", ", disjuntoresDesligados));
        }




    }
}