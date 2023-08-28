using System;

namespace Exercicio01;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Quantos números inteiros serão somados: ");
        int tamanho = int.Parse(Console.ReadLine());

        int[] numeros = new int[tamanho];

        for(int i = 0; i < tamanho; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
        }

        int soma = 0;

        for(int i = 0; i < tamanho; i++)
        {
            soma += numeros[i];
        }

        Console.WriteLine("Soma total: ");
        Console.WriteLine(soma);
    }
}

