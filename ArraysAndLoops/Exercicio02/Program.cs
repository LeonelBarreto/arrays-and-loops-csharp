namespace Exercicio02;

class Program
{
    static void Main(string[] args)
    {
        string[] array = { "A", "a", "E", "e", "E","i", "i", "O", "o", "U", "u" };

        Console.Write("Digite a vogal a ser encontrada: ");
        string vogal = Console.ReadLine();

        int contador = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (vogal == array[i])
            {
                contador++;
            }
        }

        if (contador == 0)
        {
            Console.Write($"A letra {vogal} não foi encontrada.");
        }
        else if (contador == 1)
        {
            Console.Write($"A letra {vogal} foi encontrada 1 vez.");
        }
        else
        {
            Console.Write($"A letra {vogal} foi encontrada {contador} vezes.");
        }
    }
}

