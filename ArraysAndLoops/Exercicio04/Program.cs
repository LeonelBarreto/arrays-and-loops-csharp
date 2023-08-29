namespace Exercicio04;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Escolha um número inteiro para saber seus múltiplos: ");
        int multiplo = int.Parse(Console.ReadLine());

        for (int i = 0; i <= 500; i++)
        {
            int resultado = multiplo * i;
            Console.WriteLine(resultado);
        }
    }
}

