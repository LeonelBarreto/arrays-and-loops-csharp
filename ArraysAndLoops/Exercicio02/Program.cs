namespace Exercicio02;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe a quantidade de letras que serão digitadas: ");
        int quantidade = int.Parse(Console.ReadLine());

        char[] letras = new char[quantidade];

        for (int i = 0; i < quantidade; i++)
        {
            Console.Write($"{i + 1}/{quantidade}: ");
            letras[i] = char.Parse(Console.ReadLine().ToLower());
        }

        Console.Write("Digite a vogal a ser encontrada: ");
        char letra = char.Parse(Console.ReadLine().ToLower());

        int contador = 0;

        for (int i = 0; i < letras.Length; i++)
        {
            if (letra == letras[i])
            {
                contador++;
            }
        }

        if (contador == 0)
        {
            Console.Write($"A letra {letra} não foi encontrada.");
        }
        else if (contador == 1)
        {
            Console.Write($"A letra {letra} foi encontrada 1 vez.");
        }
        else
        {
            Console.Write($"A letra {letra} foi encontrada {contador} vezes.");
        }
    }
}

