using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListActivities_3
{
    internal class Program
    {
        /*
        3 - Faça um algoritmo que leia um valor qualquer e imprima na tela com um reajuste de 5%.
        */
        static void Main(string[] args)
        {
            double number_user, result;
                Console.WriteLine("Digite um número: ");
            number_user = double.Parse(Console.ReadLine());
            result = number_user + (number_user * 0.05);
            Console.WriteLine("Seu número teve um reajuste de 5% e resultou-se em "+ result);
        }
    }
}
