using System;

namespace MaiorValor.app
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Maior Valor entre duas variáveis inteiras");

            Console.Write("Insira o valor de A: ");
            Int32.TryParse(Console.ReadLine(), out a);

            Console.Write("Insira o valor de B: ");
            Int32.TryParse(Console.ReadLine(), out b);

            Comparacao(a, b);
        }

        static void Comparacao(int a1, int b1)
        {
            if (a1 > b1)
            {
                Console.WriteLine("A variável A com o valor " + a1 + " é maior que a variável B que possui valor " + b1 );
            }
            else
            {
                Console.WriteLine("A variável B com o valor " + b1 + " é maior que a variável A que possui valor " + a1);
            }

            Console.ReadKey();
        }
    }
}
