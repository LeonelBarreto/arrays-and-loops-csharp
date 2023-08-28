namespace Exercicio03;

class Program
{
    static void Main(string[] args)
    {
        int[] arrayNumeros = { 54, 22, 14, 10, 87, 284};

        Console.Write("Digite o número a ser procurado no array: ");
        int numero = int.Parse(Console.ReadLine());


        int buscarNumero = 0;

        for(int i = 0; i < arrayNumeros.Length; i++)
        {
            if (numero == arrayNumeros[i])
            {
                buscarNumero = numero;
            }
        }

        if (buscarNumero == 0)
        {
            Console.Write(-1);
        }
        else
        {
            Console.Write(buscarNumero);
        }
    }
}

