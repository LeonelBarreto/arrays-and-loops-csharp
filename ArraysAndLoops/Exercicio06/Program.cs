namespace Exercicio06;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insira a quantidade de números que irão compor o array: ");
        int quantidade = int.Parse(Console.ReadLine());

        int[] numeros = new int[quantidade];

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
        }

        int somaPares = 0;
        int somaImpares = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] % 2 == 0)
            {
                somaPares += numeros[i];
            }
            else
            {
                somaImpares += numeros[i];
            }
        }

        Console.WriteLine();
        Console.Write("Você deseja saber a doma dos números pares ou ímpares? Responda 'par'ou 'impar': ");
        string resposta = Console.ReadLine().ToLower();

        Console.WriteLine();
        if (resposta == "par")
        {
            Console.Write(somaPares);
        }
        else if (resposta == "impar")
        {
            Console.Write(somaImpares);
        }
        else
        {
            Console.Write("Por favor inserir apenas 'par' ou 'impar'.");
        }
    }
}

