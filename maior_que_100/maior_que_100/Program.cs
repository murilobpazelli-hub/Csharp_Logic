using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maior_que_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            Console.WriteLine("Digite um número: ");
            num1 = double.Parse(Console.ReadLine());
            if (num1 > 100)
            {
                Console.WriteLine("Seu número é maior que 100!");
            }
            else
            {
                Console.WriteLine("Seu número não é maior que 100...");
            }
        }
    }
}
