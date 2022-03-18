using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(c)Raziel, 2022\n");
            Double a, b, c, med;
            Console.Write("Escreva um valor: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nEscreva um valor: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nEscreva um valor: ");
            c = Convert.ToDouble(Console.ReadLine());
            med = (a + b + c) / 3;
            Console.WriteLine("\nA sua média aritimetica é de: " + med);
            Console.Write("\nAperte uma tecla para sair...");
            Console.ReadKey();
        }
    }
}
