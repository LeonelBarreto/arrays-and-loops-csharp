namespace Exercicio15;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a quantidade de números que serão analisados: ");
        int quantidade = int.Parse(Console.ReadLine());

        int[] numeros = new int[quantidade];

        Console.WriteLine();
        Console.WriteLine("Informe os números:");
        for (int i = 0; i < quantidade; i++)
        {
            Console.Write($"{i + 1}/{quantidade}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        List<int> numerosPares = new List<int>();
        List<int> numerosImpares = new List<int>();

        foreach (int numero in numeros)
        {
            if (numero % 2 == 0)
            {
                numerosPares.Add(numero);
            }
            else
            {
                numerosImpares.Add(numero);
            }
        }

        Console.WriteLine();
        Console.Write("Números pares: ");
        Console.Write(string.Join(", ", numerosPares));
        Console.WriteLine();
        Console.Write("Números pares: ");
        Console.Write(string.Join(", ", numerosImpares));
    }
}

