using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtração
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, subtract;
            Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            subtract = num1 - num2;
            Console.WriteLine("O resultado da subtração é " + subtract);
        }
    }
}
