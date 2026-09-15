using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antecessor_Sucessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, menor, maior;
            Console.WriteLine("Escolha um número: ");
            num = int.Parse(Console.ReadLine());
            maior = num + 1;
            menor = num - 1;
            Console.WriteLine("O antecessor de " + num + " é " + menor + ", e seu sucessor é " + maior);
        }
    }
}
