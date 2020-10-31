using System;

namespace Calculos.app
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            Console.WriteLine("Soma");

            Console.Write("Insira o valor de A: ");
            Double.TryParse(Console.ReadLine(), out a);

            Console.Write("Insira o valor de B: ");
            Double.TryParse(Console.ReadLine(), out b);

            Soma(a, b);
        }

        static void Soma(double a1, double b1)
        {
            double soma = (a1 + b1);

            Console.WriteLine("\nSoma é igual a: " + soma);
            Console.ReadKey();
        }
    }
}
