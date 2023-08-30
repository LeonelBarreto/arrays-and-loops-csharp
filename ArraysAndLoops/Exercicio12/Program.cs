namespace Exercicio12;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("A fila do Banco está vazia? Digite 's' para sim e 'n' para não: ");
        string respostaFila = Console.ReadLine();

        if (respostaFila == "s" || respostaFila == "S")
        {
            Console.Write("Informe a quantidade de pessoas: ");
            int quantidadeDentro = int.Parse(Console.ReadLine());

            string[] filaExistente = new string[quantidadeDentro];

            for (int i = 0; i < quantidadeDentro; i++)
            {
                Console.Write($"({i + 1}/{quantidadeDentro}) Nome do Cliente : ");
                filaExistente[i] = Console.ReadLine();
            }
            Console.Write("Fila atual DENTRO do banco: ");
            Console.Write(string.Join(", ", filaExistente));

            Console.WriteLine();

            Console.Write("Informe a quantidade de pessoas estão na fila externa do banco: ");
            int quantidadeFora = int.Parse(Console.ReadLine());

            string[] filaExterna = new string[quantidadeFora];

            for (int i = 0; i < quantidadeFora; i++)
            {
                Console.Write($"({i + 1}/{quantidadeFora}) Nome do Cliente : ");
                filaExterna[i] = Console.ReadLine();
            }

            List<string> filaDentro = filaExistente.ToList();
            List<string> filaFora = filaExterna.ToList();

            Console.WriteLine();
            Console.Write("Fila atual DENTRO do banco: ");
            Console.Write(string.Join(", ", filaDentro));
            Console.WriteLine();
            Console.Write("Fila atual FORA do banco: ");
            Console.Write(string.Join(", ", filaFora));
            Console.WriteLine();

            while (filaDentro.Count < 5 )
            {
                filaDentro.Add(filaFora[0]);
                filaFora.RemoveAt(0);

                if (filaFora == null)
                {
                    break;
                }
            }
            Console.WriteLine();
            Console.Write("Resultado Final de quem está na FILA DE DENTRO: ");
            Console.Write(string.Join(", ", filaDentro));
            Console.WriteLine();
            Console.Write("Resultado Final de quem está na FILA DE FORA: ");
            Console.Write(string.Join(", ", filaFora));
        }
        else if (respostaFila == "n" || respostaFila == "N")
        {
            List<string> filaInterna = new List<string>();

            if (filaInterna == null)
            {
                Console.WriteLine("Banco sem fila.");
            }

            Console.Write("Informe a quantidade de pessoas estão na fila externa do banco: ");
            int quantidadeFora = int.Parse(Console.ReadLine());

            string[] filaExterna = new string[quantidadeFora];

            for (int i = 0; i < quantidadeFora; i++)
            {
                Console.Write($"({i + 1}/{quantidadeFora}) Nome do Cliente : ");
                filaExterna[i] = Console.ReadLine();
            }

            List<string> filaDentro = filaInterna.ToList();
            List<string> filaFora = filaExterna.ToList();

            Console.WriteLine();
            Console.Write("Fila atual DENTRO do banco: ");
            Console.Write(string.Join(", ", filaDentro));
            Console.WriteLine();
            Console.Write("Fila atual FORA do banco: ");
            Console.Write(string.Join(", ", filaFora));
            Console.WriteLine();

            while (filaDentro.Count < 5)
            {
                filaDentro.Add(filaFora[0]);
                filaFora.RemoveAt(0);

                if (filaFora == null)
                {
                    break;
                }
            }
            Console.WriteLine();
            Console.Write("Resultado Final de quem está na FILA DE DENTRO: ");
            Console.Write(string.Join(", ", filaDentro));
            Console.WriteLine();
            Console.Write("Resultado Final de quem está na FILA DE FORA: ");
            Console.Write(string.Join(", ", filaFora));

        }
        


    }
}

