using System;
using System.Collections.Concurrent;

namespace Exercicio05;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira a quantidade de números inteiros que serão inseridos no array:");
        int quantidade = int.Parse(Console.ReadLine());
        int[] numeros = new int[quantidade];

        for (int i = 0; i < 7; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
        }

        
        Console.WriteLine();
        Console.Write("Você deseja filtar os números ímpares ou pares? Escreva impar ou par: ");
        string filtro = Console.ReadLine().ToLower();

        List<int> resultadoPar = new List<int>();
        List<int> resultadoImpar = new List<int>();

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] % 2 == 0)
            {
                resultadoPar.Add(numeros[i]);
            }
            else
            {
                resultadoImpar.Add(numeros[i]);
            }
        }

        if (filtro == "par")
        {
            Console.WriteLine(string.Join(", ", resultadoPar));
        }
        else if (filtro == "impar")
        {
            Console.WriteLine(string.Join(", ", resultadoImpar));
        }
        else
        {
            Console.Write("Por favor, digitar apenas 'impar' ou 'par'.");
        }
    }
}

