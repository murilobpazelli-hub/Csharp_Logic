using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Store_Discount_Calculus
{
    internal class Program
    {/* 
      5. Calcular desconto:
        Um produto com preço acima de 100 reais tem um desconto de 10%. Caso contrário, o desconto é de 5%.
          Dado o preço, calcule o valor do desconto.
        Entrada: 120
        Saída esperada: 12 reais de desconto.
      */
        static void Main(string[] args)
        {
            double price, discount;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"
▒█▀▀█ █▀▀█ █░░ █▀▀ █░░█ █░░ █▀▀█ 　 █▀▀▄ █▀▀ 　 █▀▀▄ █▀▀ █▀▀ █▀▀ █▀▀█ █▀▀▄ ▀▀█▀▀ █▀▀█ 　 █▀▀▄ █▀▀█ 
▒█░░░ █▄▄█ █░░ █░░ █░░█ █░░ █░░█ 　 █░░█ █▀▀ 　 █░░█ █▀▀ ▀▀█ █░░ █░░█ █░░█ ░░█░░ █░░█ 　 █░░█ █▄▄█ 
▒█▄▄█ ▀░░▀ ▀▀▀ ▀▀▀ ░▀▀▀ ▀▀▀ ▀▀▀▀ 　 ▀▀▀░ ▀▀▀ 　 ▀▀▀░ ▀▀▀ ▀▀▀ ▀▀▀ ▀▀▀▀ ▀░░▀ ░░▀░░ ▀▀▀▀ 　 ▀▀▀░ ▀░░▀ 

█░░ █▀▀█ ░░▀ █▀▀█ 
█░░ █░░█ ░░█ █▄▄█ 
▀▀▀ ▀▀▀▀ █▄█ ▀░░▀");
            Console.ResetColor();
            Console.WriteLine("Por favor digite o preço de seu produto: ");
            price = double.Parse(Console.ReadLine());
            if (price > 100)
            {
                discount = price * 0.10;
                Console.WriteLine("\n" + discount + " reais de desconto.");
            }
            else
            {
                discount = price * 0.05 ;
                Console.WriteLine("\n" + discount + " reais de desconto.");
            }
        }
    }
}
