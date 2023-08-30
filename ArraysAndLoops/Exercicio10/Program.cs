namespace Exercicio10;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a quantidade de números inteiros que serão adicionados ao array: ");
        int quantidade = int.Parse(Console.ReadLine());

        int[] numeros = new int[quantidade];

        for (int i = 0; i < quantidade; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
        }

        int maiorDiferenca = 0;

        foreach (int x in numeros)
        {
            foreach (int y in numeros)
            {
                int diferencaAtual = x - y;

                if (diferencaAtual > maiorDiferenca)
                {
                    maiorDiferenca = diferencaAtual;
                }
            }
        }

        Console.Write(maiorDiferenca);
    }
}

