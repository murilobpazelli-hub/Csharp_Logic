using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ano_Bissexto
{
    /* 6. Ano bissexto
     * Determine se um ano é bissexto. Um ano é bissexto se for divisível por 4, mas não por 100, a não
     * ser que seja divisível por 400.
     Entrada: 2024
     Saída esperada: Ano bissexto
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
░█████╗░███╗░░██╗░█████╗░  ██████╗░██╗░██████╗░██████╗███████╗██╗░░██╗████████╗░█████╗░
██╔══██╗████╗░██║██╔══██╗  ██╔══██╗██║██╔════╝██╔════╝██╔════╝╚██╗██╔╝╚══██╔══╝██╔══██╗
███████║██╔██╗██║██║░░██║  ██████╦╝██║╚█████╗░╚█████╗░█████╗░░░╚███╔╝░░░░██║░░░██║░░██║
██╔══██║██║╚████║██║░░██║  ██╔══██╗██║░╚═══██╗░╚═══██╗██╔══╝░░░██╔██╗░░░░██║░░░██║░░██║
██║░░██║██║░╚███║╚█████╔╝  ██████╦╝██║██████╔╝██████╔╝███████╗██╔╝╚██╗░░░██║░░░╚█████╔╝
╚═╝░░╚═╝╚═╝░░╚══╝░╚════╝░  ╚═════╝░╚═╝╚═════╝░╚═════╝░╚══════╝╚═╝░░╚═╝░░░╚═╝░░░░╚════╝░");
                Console.ResetColor();
            Console.WriteLine("Digite o ano e irei verificar se ele é bissexto: ");
            year = int.Parse(Console.ReadLine());
            if (year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine("Ano bissexto.");
            }
            else if (year % 400 == 0)
            {
                Console.WriteLine("Ano bissexto.");
            }
            else
            {
                Console.WriteLine("Não bissexto.");
            }
        }
    }
}
