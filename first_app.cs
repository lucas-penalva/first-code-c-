using System;

class Program
{
    public static void Main(string[] args)
    {
        float propor; float e; float g; string r = true;
        Console.WriteLine("Digite o preço do etanol: ");
        e = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o preço do gasolina: ");
        g = float.Parse(Console.ReadLine());
        propor = e / g;

        if (propor > 0.7)
        {
            Console.WriteLine("Vale a pena abastecer com etanol!");
        }

        else if (propor < 0.7)
        {
            Console.WriteLine("Vale a pena abastecer com gasolina!");
        }

        else
        {
            Console.WriteLine("Tanto faz");

        }

        Console.WriteLine("Deseja efetuar um novo cálculo? Digite 'Sim' ou 'Não'2");
        r = Console.ReadLine();

        if (r == "Sim")
        {
            Console.WriteLine("Digite o preço do etanol: ");
            e = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço do gasolina: ");
            g = float.Parse(Console.ReadLine());
            propor = e / g;

            if (propor > 0.7)
            {
                Console.WriteLine("Vale a pena abastecer com etanol!");
            }

            else if (propor < 0.7)
            {
                Console.WriteLine("Vale a pena abastecer com gasolina!");
            }
        }

        else if (r == "Não")
        {
            Console.WriteLine("Encerrar Programa");
        }

    }

}