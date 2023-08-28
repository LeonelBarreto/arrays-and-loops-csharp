namespace Exercicio03;

class Program
{
    static void Main(string[] args)
    {
        int[] arrayNumeros = { 54, 22, 14, 10, 87, 284};

        Console.Write("Digite o número a ser procurado no array: ");
        int numero = int.Parse(Console.ReadLine());


        int buscarIndice = -1;

        for(int i = 0; i < arrayNumeros.Length; i++)
        {
            int buscarNumero = arrayNumeros[i];
            if (buscarNumero == numero)
            {
                buscarIndice = i;
                break;
            }
        }

        Console.Write(buscarIndice);
    }
}

