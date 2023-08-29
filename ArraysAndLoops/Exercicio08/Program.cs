namespace Exercicio08;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a quantidade de números inteiros que terá o array criado: ");
        int quantidade = int.Parse(Console.ReadLine());

        int[] numeros = new int[quantidade];

        for (int i = 0; i < quantidade; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();

        int maiorNumero = 0;

        foreach (var numero in numeros)
        {
            if ( numero > maiorNumero)
            {
                maiorNumero = numero;
            }
        }

        Console.WriteLine($"O maior número encontrado foi: {maiorNumero}.");
    }
}

