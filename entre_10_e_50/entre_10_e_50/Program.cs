using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entre_10_e_50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            Console.WriteLine("Digite um número: ");
            num1 = double.Parse(Console.ReadLine());
            if (num1 >= 10 && num1 <= 50)
            {
                Console.WriteLine("Seu número está entre 10 e 50!");
            }
            else
            {
                Console.WriteLine("Seu número não está entre 10 e 50...");
            }
        }
    }
}
