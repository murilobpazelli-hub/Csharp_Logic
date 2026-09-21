using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListActivities7
{ /*
   7- Faça um algoritmo que receba um valor A e B, e troque o valor de A por B e o valor 
     de B por A e imprima na tela os valores.
   
   
   
   */
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorA, valorB;
            Console.WriteLine("Digite o valor A: ");
            valorA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor B: ");
            valorB = int.Parse(Console.ReadLine());

            if (valorA != valorB)
            {
                valorA = valorB;
            }
            if (valorB != valorA)
            {

                valorB = valorA;

                
            }
            Console.WriteLine("O Valor A é igual a " + valorA + " e o Valor B é igual a " + valorB);
        }
    }
}

