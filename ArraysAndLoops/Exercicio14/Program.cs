namespace Exercicio14;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a quantidade de numeros que irão compor cada array: ");
        int quantidade = int.Parse(Console.ReadLine());

        int[] array1 = new int[quantidade];
        int[] array2 = new int[quantidade];

        Console.WriteLine();

        Console.WriteLine($"Digite {quantidade} números que irão compor o Array 1: ");
        for (int i = 0; i < quantidade; i++)
        {
            Console.Write($"{i + 1}/{quantidade}: ");
            array1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();

        Console.WriteLine($"Digite {quantidade} números que irão compor o Array 2: ");
        for (int i = 0; i < quantidade; i++)
        {
            Console.Write($"{i + 1}/{quantidade}: ");
            array2[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        Console.Write("Você deseja saber saber qual é o número maior ou menor na comparação entre os arrays? Digite 'menor'ou maior': ");
        string resposta = Console.ReadLine().ToLower();

        Console.WriteLine();

        if (resposta == "maior")
        {
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] > array2[i])
                {
                    Console.WriteLine($"{array1[i]} - Array 1");
                }
                else
                {
                    Console.WriteLine($"{array2[i]} - Array 2");
                }
            }
        }
        else if (resposta == "menor")
        {
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] < array2[i])
                {
                    Console.WriteLine($"{array1[i]} - Array 1");
                }
                else
                {
                    Console.WriteLine($"{array2[i]} - Array 2");
                }
            }
        }
        else
        {
            Console.Write("Por favor digitar apenas MAIOR ou MENOR.");
        }
    }
}

