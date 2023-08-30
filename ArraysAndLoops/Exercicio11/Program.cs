namespace Exercicio11;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe a quantidade de números inteiros que serão inseridos no array: ");
        int quantidade = int.Parse(Console.ReadLine());

        int[] numeros = new int[quantidade];

        Console.WriteLine("Insira números entre 0 e 300:");

        for (int i = 0; i < quantidade; i++)
        {
            Console.Write($"Nº{i + 1}/{quantidade}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        List<int> filtroDeNumeros = new List<int>();

        foreach (int numero in numeros)
        {
            if ((numero > 10 && numero < 20) || numero > 100)
            {
                filtroDeNumeros.Add(numero);
            }
        }
        Console.Write("Resultado: ");
        Console.Write(string.Join(", ", filtroDeNumeros));
    }
}

