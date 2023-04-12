using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1EX1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int B;
            int h;
            int a;
            Console.Write("Insira a base do Retângulo: ");
            B = int.Parse(Console.ReadLine());
            Console.Write("Insira a altura do Retângulo: ");
            h = int.Parse(Console.ReadLine());

            a = B * h;

            Console.WriteLine("A area do retangulo é {0}.", a);

        }
    }
}
