using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maior_entre_todos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, n5;
            Console.WriteLine("Digite o primeiro número: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número: ");
            n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quarto número: ");
            n4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quinto número: ");
            n5 = double.Parse(Console.ReadLine());
            if (n1 > n2 && n1 > n3 && n1 > n4 && n1 > n5)
            {
                Console.WriteLine("O maior número é: " + n1);
            }
            else if (n2 > n1 && n2 > n3 && n2 > n4 && n2 > n5)
            {
                Console.WriteLine("O maior número é: " + n2);
            }
            else if (n3 > n1 && n3 > n2 && n3 > n4 && n3 > n5)
            {
                Console.WriteLine("O maior número é: " + n3);
            }
            else if (n4 > n1 && n4 > n2 && n4 > n3 && n4 > n5)
            {
                Console.WriteLine("O maior número é: " + n4);
            }
            else {
                Console.WriteLine("O maior número é: " + n5);
            }
        }
    }
}
